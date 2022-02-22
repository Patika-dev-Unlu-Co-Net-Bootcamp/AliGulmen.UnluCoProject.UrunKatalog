using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Extensions
{
    public static class CustomGlobalExceptionExtension
    {
        // to use in start.cs : app.UseCustomGlobalException() instead of app.UseMiddleware<CustomGlobalException>();
        public static IApplicationBuilder UseCustomGlobalException(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<CustomGlobalException>();
        }
    }
}
