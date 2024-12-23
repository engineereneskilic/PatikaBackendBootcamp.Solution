using System.Runtime.CompilerServices;

namespace _13.week_04_Middleware.Models
{
    public class RequestLoggingMiddleware
    {

        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync (HttpContext context)
        {
            // istek bilgilerini yazdırma
            await Console.Out.WriteLineAsync($"İstek: {context.Request.Method} {context.Request.Path}");

            //Diğer Middleware'e geçiş

            await _next(context);

            // yanıt bilgilerini yazdırma
            await Console.Out.WriteLineAsync($"Yanıt: {context.Response.StatusCode}");
        }
    }
}
