using FlavorVerse.Application.BusinessLogic.Audits.Queries;
using FlavorVerse.Application.BusinessLogic.Categories.Commands.Admin;
using FlavorVerse.Application.BusinessLogic.Cuisines.Commands.Admin;
using FlavorVerse.Application.BusinessLogic.Ingredients.Commands.Admin;
using FlavorVerse.Application.BusinessLogic.Users.Commands.Admin;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Dtos.Role;
using FlavorVerse.Application.Dtos.Status;
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

    [HttpDelete("category/{id}")]
    public async Task<IActionResult> DeleteCategory([FromRoute] int id)
    {
        var result = await Mediator.Send(new DeleteCategoryCommand(id));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Category>(result.Error);
    }

    [HttpPut("category/{id}")]
    public async Task<IActionResult> UpdateCategory([FromRoute] int id, UpdateCategoryDto category)
    {
        var result = await Mediator.Send(new UpdateCategoryCommand(id, category));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Category>(result.Error);
    }

    [HttpPost("cuisine")]
    public async Task<IActionResult> AddCuisine([FromBody] AddCuisineDto cuisine)
    {
        var result = await Mediator.Send(new AddCuisineCommand(cuisine));

        if (result.IsSuccess)
        {
            return Created();
        }

        return this.HandleErrorResponse<Cuisine>(result.Error);
    }

    [HttpPost("category")]
    public async Task<IActionResult> AddCategory([FromBody] AddCategoryDto category)
    {
        var result = await Mediator.Send(new AddCategoryCommand(category));

        if (result.IsSuccess)
        {
            return Created();
        }

        return this.HandleErrorResponse<Category>(result.Error);
    }

    [HttpDelete("cuisine/{id}")]
    public async Task<IActionResult> DeleteCuisine([FromRoute] int id)
    {
        var result = await Mediator.Send(new DeleteCuisineCommand(id));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Cuisine>(result.Error);
    }

    [HttpPut("cuisine/{id}")]
    public async Task<IActionResult> UpdateCuisine([FromRoute] int id, UpdateCuisineDto cuisine)
    {
        var result = await Mediator.Send(new UpdateCuisineCommand(id, cuisine));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Cuisine>(result.Error);
    }

    [HttpPost("ingredient")]
    public async Task<IActionResult> AddIngredient([FromBody] AddIngredientDto ingredient)
    {
        var result = await Mediator.Send(new AddIngredientCommand(ingredient));

        if (result.IsSuccess)
        {
            return Created();
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }

    [HttpDelete("ingredient/{id}")]
    public async Task<IActionResult> DeleteIngredient([FromRoute] int id)
    {
        var result = await Mediator.Send(new DeleteIngredientCommand(id));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }

    [HttpPut("ingredient/{id}")]
    public async Task<IActionResult> UpdateIngredient([FromRoute] int id, UpdateIngredientDto ingredient)
    {
        var result = await Mediator.Send(new UpdateIngredientCommand(id, ingredient));

        if (result.IsSuccess)
        {
            return NoContent();
        }

        return this.HandleErrorResponse<Ingredient>(result.Error);
    }
}