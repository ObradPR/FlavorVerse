﻿using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Common;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace FlavorVerse.Application.Identity.Middlewares;

public class UserContextMiddleware
{
    private readonly RequestDelegate _next;

    public UserContextMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            var userIdClaim = "";

            if (context.User.FindFirstValue(ClaimTypes.NameIdentifier) is null)
            {
                userIdClaim = Constants.SYSTEM_USER_ID;
            }
            else
            {
                userIdClaim = context.User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            }

            UserContext.CurrentUserId = Guid.Parse(userIdClaim);

            var roles = context.User.Claims
                .Where(x => x.Type == ClaimTypes.Role)
                .Select(x => x.Value)
                .ToList();

            UserContext.CurrentRoles = roles;

            await _next(context);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}