using FlavorVerse.Application.BusinessLogic.Categories.Commands;
using FlavorVerse.Application.BusinessLogic.Categories.Queries;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.WebApi.Controllers._BaseApiController;
using FlavorVerse.WebApi.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Controllers;

public class CategoryController : BaseApiController
{
    public CategoryController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] QueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllCategoriesQuery(queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Category>(result.Error);
    }

    [HttpGet("recipe/{id}")]
    public async Task<IActionResult> GetCategoriesForRecip([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new GetCategoriesForRecipeQuery(id));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Category>(result.Error);
    }

    [HttpPost("recipe")]
    [Authorize]
    public async Task<IActionResult> AddCategoriesToRecipe([FromBody] AddCategoriesToRecipeDto addCategories)
    {
        var result = await Mediator.Send(new AddCategoriesToRecipeCommand(addCategories));

        if (result.IsSuccess)
        {
            return Created();
        }

        return this.HandleErrorResponse<Category>(result.Error);
    }

    [HttpDelete("{categoryId}/recipe/{recipeId}")]
    [Authorize]
    public async Task<IActionResult> DeleteCategoryForRecipe([FromRoute] int categoryId, [FromRoute] Guid recipeId)
    {
        var result = await Mediator.Send(new DeleteCategoryForRecipeCommand(new DeleteCategoryForRecipeDto
        {
            CategoryId = categoryId,
            RecipeId = recipeId
        }));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Category>(result.Error);
    }
}