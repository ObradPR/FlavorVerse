using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Nutrition;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Nutritions.Queries;

public class GetNutrtionByRecipeQuery : IQuery<NutritionDto>
{
    public Guid Id { get; set; }

    public GetNutrtionByRecipeQuery(Guid id) => Id = id;

    // Handler
    public class GetNutrtionByRecipeHandler : BaseHandler, IQueryHandler<GetNutrtionByRecipeQuery, NutritionDto>
    {
        public GetNutrtionByRecipeHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<NutritionDto>> Handle(GetNutrtionByRecipeQuery request, CancellationToken cancellationToken)
        {
            var nutrition = await UnitOfWork.NutritionRepository.GetNutritionByRecipeIdAsync(request.Id, cancellationToken);

            if (nutrition is null)
            {
                return Result.Failure<NutritionDto>(Error<Nutrition>.NotFound);
            }

            var nutritionMapped = Mapper.Map<NutritionDto>(nutrition);

            return Result.Success(nutritionMapped);
        }
    }
}