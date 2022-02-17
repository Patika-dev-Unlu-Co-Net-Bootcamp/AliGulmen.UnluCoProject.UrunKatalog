using AliGulmen.UnluCoProject.UrunKatalog.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace AliGulmen.UnluCoProject.UrunKatalog.Extensions
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
