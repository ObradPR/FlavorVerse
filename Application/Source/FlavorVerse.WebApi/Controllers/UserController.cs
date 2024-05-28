using FlavorVerse.Application.BusinessLogic.Users.Commands;
using FlavorVerse.Application.BusinessLogic.Users.Queries;
using FlavorVerse.Application.Dtos.User;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.WebApi.Controllers._BaseApiController;
using FlavorVerse.WebApi.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Controllers;

public class UserController : BaseApiController
{
    public UserController(IMediator mediator) : base(mediator)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        if (ControllerExtensions.HaveAccess(id))
        {
            var result = await Mediator.Send(new DeleteUserCommand(id));

            if (result.IsSuccess)
            {
                return NoContent();
            }

            return this.HandleErrorResponse<User>(result.Error);
        }

        return StatusCode(403, Error.ActionForbidden);
    }

    [HttpPut("profile/{id}")]
    [Authorize]
    public async Task<IActionResult> Update([FromRoute] Guid id, UpdateUserProfileDto user)
    {
        if (ControllerExtensions.HaveAccess(id))
        {
            var result = await Mediator.Send(new UpdateUserProfileCommand(id, user));

            if (result.IsSuccess)
            {
                return NoContent();
            }

            return this.HandleErrorResponse<User>(result.Error);
        }

        return StatusCode(403, Error.ActionForbidden);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new GetUserQuery(id));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<User>(result.Error);
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll([FromQuery] QueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllUsersQuery(queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<User>(result.Error);
    }
}