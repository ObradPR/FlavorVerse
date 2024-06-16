using FlavorVerse.Application.BusinessLogic.Ratings.Commands;
using FlavorVerse.Application.BusinessLogic.Ratings.Queries;
using FlavorVerse.Application.BusinessLogic.Ratings.Queries.Admin;
using FlavorVerse.Application.BusinessLogic.Recipes.Commands;
using FlavorVerse.Application.BusinessLogic.Recipes.Queries;
using FlavorVerse.Application.BusinessLogic.Users.Commands;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Dtos.User;
using FlavorVerse.Common;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.WebApi.Controllers._BaseApiController;
using FlavorVerse.WebApi.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Controllers;

public class RatingController : BaseApiController
{
    public RatingController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    [Authorize(Policy = Constants.ADMIN)]
    public async Task<IActionResult> GetAll([FromQuery] QueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllRatingsQuery(queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Rating>(result.Error);
    }

    [HttpGet("user/{id}")]
    public async Task<IActionResult> GetRatingsByUserId([FromRoute] Guid id, [FromQuery] QueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllRatingsByUserQuery(id, queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Rating>(result.Error);
    }

    [HttpGet("recipe/{id}")]
    public async Task<IActionResult> GetRatingsByRecipeId([FromRoute] Guid id, [FromQuery] QueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllRatingsByRecipeQuery(id, queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Rating>(result.Error);
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteRating([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new DeleteRatingCommand(id));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Rating>(result.Error);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> CreateRating([FromBody] NewRatingDto rating)
    {
        var result = await Mediator.Send(new AddRatingCommand(rating));

        if (result.IsSuccess)
        {
            return Created();
        }

        return this.HandleErrorResponse<Rating>(result.Error);
    }

    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRatingDto rating)
    {
        var result = await Mediator.Send(new UpdateRatingCommand(id, rating));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Rating>(result.Error);
    }
}