using FlavorVerse.Application.BusinessLogic.Audits.Queries;
using FlavorVerse.Application.BusinessLogic.Users.Commands;
using FlavorVerse.Application.BusinessLogic.Users.Commands.Admin;
using FlavorVerse.Application.Dtos.Role;
using FlavorVerse.Application.Dtos.Status;
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

[Authorize(Policy = Constants.ADMIN)]
public class AdminController : BaseApiController
{
    public AdminController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPut("user-roles/{id}")]
    public async Task<IActionResult> UpdateUserRoles([FromRoute] Guid id, RoleDto roles)
    {
        var result = await Mediator.Send(new AdminUpdateUserRolesCommand(id, roles));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<User>(result.Error);
    }

    [HttpPut("user-status/{id}")]
    public async Task<IActionResult> UpdateUserStatus([FromRoute] Guid id, StatusDto status)
    {
        var result = await Mediator.Send(new AdminUpdateUserStatusCommand(id, status));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<User>(result.Error);
    }

    [HttpGet("audits")]
    public async Task<IActionResult> GetAllAudits([FromQuery] AuditQueryParams queryParams)
    {
        var result = await Mediator.Send(new GetAllAuditsQuery(queryParams));

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return this.HandleErrorResponse<Audit>(result.Error);
    }
}