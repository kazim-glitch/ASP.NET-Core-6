using System.Globalization; 
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
//using MVCmovie.Data; 



namespace MVCmovie
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger; 

        public Middleware(RequestDelegate next, ILoggerFactory logfactory)
        {

            _next = next;
            _logger = logfactory.CreateLogger("My middleware"); 
        }

        public  async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("Middleware executing"); 

            await  _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
