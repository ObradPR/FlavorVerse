using FlavorVerse.Application.BusinessLogic.Cuisines.Commands;
using FlavorVerse.Application.BusinessLogic.Cuisines.Queries;
using FlavorVerse.Application.BusinessLogic.Ingredients.Commands;
using FlavorVerse.Application.BusinessLogic.Ingredients.Queries;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.WebApi.Controllers._BaseApiController;
using FlavorVerse.WebApi.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Controllers;

public class IngredientController : BaseApiController
{
    public IngredientController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] QueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllIngredientsQuery(queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }

    [HttpGet("recipe/{id}")]
    public async Task<IActionResult> GetCuisineForRecip([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new GetIngredientsForRecipeQuery(id));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }

    [HttpPost("recipe")]
    [Authorize]
    public async Task<IActionResult> AddIngredientsToRecipe([FromBody] AddIngredientsToRecipeDto addIngredients)
    {
        var result = await Mediator.Send(new AddIngredientsToRecipeCommand(addIngredients));

        if (result.IsSuccess)
        {
            return Created();
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }

    [HttpDelete("{ingredientId}/recipe/{recipeId}")]
    [Authorize]
    public async Task<IActionResult> DeleteCategoryForRecipe([FromRoute] int ingredientId, [FromRoute] Guid recipeId)
    {
        var result = await Mediator.Send(new DeleteIngredientForRecipeCommand(new DeleteIngredientForRecipeDto
        {
            IngredientId = ingredientId,
            RecipeId = recipeId
        }));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }

    [HttpPut("{ingredientId}/recipe/{recipeId}")]
    [Authorize]
    public async Task<IActionResult> EditRecipeIngredient([FromRoute] Guid recipeId, [FromRoute] int ingredientId, [FromBody] EditRecipeIngredientDto ingredient)
    {
        var result = await Mediator.Send(new EditRecipeIngredientCommand(recipeId, ingredientId, ingredient));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }
}