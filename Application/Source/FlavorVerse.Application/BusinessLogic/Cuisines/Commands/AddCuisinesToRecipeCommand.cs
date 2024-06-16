using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Cuisines.Commands;

public class AddCuisinesToRecipeCommand : ICommand
{
    public AddCuisinesToRecipeDto AddCuisinesDto { get; set; }

    public AddCuisinesToRecipeCommand(AddCuisinesToRecipeDto addCuisinesDto) => AddCuisinesDto = addCuisinesDto;

    // Validators
    public class AddCuisinesToRecipeValidtion : AbstractValidator<AddCuisinesToRecipeDto>
    {
        public AddCuisinesToRecipeValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.RecipeId)
               .NotEmpty()
               .WithMessage("Recipe id is required.")
               .MustAsync(unitOfWork.RecipeRepository.RecipeExistByIdAsync)
               .WithMessage("Recipe with given id doesn't exists.");

            RuleFor(x => x.Cuisines)
                .NotEmpty()
                .WithMessage("Cuisines are required.");
        }
    }

    // Handler
    public class AddCuisinesToRecipeHandler : BaseHandler<AddCuisinesToRecipeDto>, ICommandHandler<AddCuisinesToRecipeCommand>
    {
        public AddCuisinesToRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<AddCuisinesToRecipeDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AddCuisinesToRecipeCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.AddCuisinesDto.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var validationResult = await Validator.ValidateAsync(request.AddCuisinesDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AddCuisinesToRecipeDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.AddCuisinesDto.RecipeId, eEntityType.RecipeCuisine, eActionType.Insert, UserContext.CurrentUserId, async () =>
            {
                var newCuisines = new List<RecipeCuisine>();

                foreach (var id in request.AddCuisinesDto.Cuisines)
                {
                    var cuisine = await UnitOfWork.CuisineRepository.GetCuisineByIdAsync(id, cancellationToken) ?? throw new ArgumentException($"Cuisine with given id {id} doesn't exist. Action is terminated");

                    if (recipe.RecipeCuisines.FirstOrDefault(x => x.CuisineId == id) is not null)
                    {
                        continue;
                    }

                    newCuisines.Add(new RecipeCuisine
                    {
                        CuisineId = id,
                        RecipeId = request.AddCuisinesDto.RecipeId
                    });
                }

                if (newCuisines.Count == 0)
                {
                    return Result.Success("This recipe already contains this cuisines.");
                }

                await UnitOfWork.RecipeRepository.AddRecipeCuisinesAsync(newCuisines, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully added cuisines.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}