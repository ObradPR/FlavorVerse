using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Extensions;

public static class ControllerExtensions
{
    public static IActionResult HandleErrorResponse<T>(this ControllerBase controller, Result result)
    {
        if (result.Error == Error<T>.NotFound)
        {
            return controller.NotFound(result.Error);
        }

        if (result.Error == Error.SaveChangesFailed
            || result.Error == Error.Transaction)
        {
            return controller.StatusCode(500, result.Error);
        }

        if (result.Error is ValidationError)
        {
            return controller.UnprocessableEntity(result.Error);
        }

        if (result.Error == Error.ActionForbidden)
        {
            return controller.StatusCode(403, result.Error);
        }

        if (result.Error == Error.Conflict)
        {
            return controller.StatusCode(409, result.Error);
        }

        return controller.BadRequest(result.Error);
    }

    public static bool HaveAccess(Guid id)
    {
        var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

        return UserContext.CurrentUserId.Equals(id) || !string.IsNullOrEmpty(adminRole);
    }
}