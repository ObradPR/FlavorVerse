using FlavorVerse.Application.BusinessLogic.Nutritions.Commands;
using FlavorVerse.Application.BusinessLogic.Nutritions.Queries;
using FlavorVerse.Application.BusinessLogic.Ratings.Commands;
using FlavorVerse.Application.BusinessLogic.Ratings.Queries;
using FlavorVerse.Application.BusinessLogic.Recipes.Commands;
using FlavorVerse.Application.Dtos.Nutrition;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.WebApi.Controllers._BaseApiController;
using FlavorVerse.WebApi.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Controllers;

public class NutritionController : BaseApiController
{
    public NutritionController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet("recipe/{id}")]
    public async Task<IActionResult> GetNutritionByRecipeId([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new GetNutrtionByRecipeQuery(id));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Nutrition>(result.Error);
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteNutrition([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new DeleteNutritionCommand(id));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Nutrition>(result.Error);
    }

    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateNutritionDto nutrition)
    {
        var result = await Mediator.Send(new UpdateNutritionCommand(id, nutrition));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Nutrition>(result.Error);
    }
}