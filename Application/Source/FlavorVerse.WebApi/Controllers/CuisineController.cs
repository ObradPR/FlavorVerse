using FlavorVerse.Application.BusinessLogic.Categories.Commands;
using FlavorVerse.Application.BusinessLogic.Categories.Queries;
using FlavorVerse.Application.BusinessLogic.Cuisines.Commands;
using FlavorVerse.Application.BusinessLogic.Cuisines.Queries;
using FlavorVerse.Application.BusinessLogic.Ingredients.Commands;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.WebApi.Controllers._BaseApiController;
using FlavorVerse.WebApi.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Controllers;

public class CuisineController : BaseApiController
{
    public CuisineController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] QueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllCuisinesQuery(queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Cuisine>(result.Error);
    }

    [HttpGet("recipe/{id}")]
    public async Task<IActionResult> GetCuisineForRecip([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new GetCuisinesForRecipeQuery(id));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Cuisine>(result.Error);
    }

    [HttpPost("recipe")]
    [Authorize]
    public async Task<IActionResult> AddCuisinesToRecipe([FromBody] AddCuisinesToRecipeDto addCuisines)
    {
        var result = await Mediator.Send(new AddCuisinesToRecipeCommand(addCuisines));

        if (result.IsSuccess)
        {
            return Created();
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }

    [HttpDelete("{cuisineId}/recipe/{recipeId}")]
    [Authorize]
    public async Task<IActionResult> DeleteCategoryForRecipe([FromRoute] int cuisineId, [FromRoute] Guid recipeId)
    {
        var result = await Mediator.Send(new DeleteCuisineForRecipeCommand(new DeleteCuisineForRecipeDto
        {
            CuisineId = cuisineId,
            RecipeId = recipeId
        }));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Cuisine>(result.Error);
    }
}