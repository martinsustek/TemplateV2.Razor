﻿using Microsoft.AspNetCore.Builder;

namespace TemplateV2.Razor.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSessionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SessionMiddleware>();
        }

        public static IApplicationBuilder UseAdminCreationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AdminCreationMiddleware>();
        }
    }
}
