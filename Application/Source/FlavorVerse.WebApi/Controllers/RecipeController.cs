using FlavorVerse.Application.BusinessLogic.Recipes.Commands;
using FlavorVerse.Application.BusinessLogic.Recipes.Queries;
using FlavorVerse.Application.Dtos.Recipe;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.WebApi.Controllers._BaseApiController;
using FlavorVerse.WebApi.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Controllers;

public class RecipeController : BaseApiController
{
    public RecipeController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] QueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllRecipesQuery(queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Recipe>(result.Error);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRecipeById([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new GetSingleRecipeByIdQuery(id));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Recipe>(result.Error);
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteRecipe([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new DeleteRecipeCommand(id));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Recipe>(result.Error);
    }

    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> UpdateRecipe([FromRoute] Guid id, [FromForm] UpdateRecipeDto recipe)
    {
        var result = await Mediator.Send(new UpdateRecipeCommand(id, recipe));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Recipe>(result.Error);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddRecipe([FromForm] AddRecipeDto recipe)
    {
        var result = await Mediator.Send(new AddRecipeCommand(recipe));

        if (result.IsSuccess)
        {
            return Created();
        }

        return this.HandleErrorResponse<Recipe>(result.Error);
    }
}