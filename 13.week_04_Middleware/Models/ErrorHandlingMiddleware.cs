using System.Runtime.CompilerServices;

namespace _13.week_04_Middleware.Models
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context); // Diğer middleware geç
            }
            catch (Exception)
            {
                //Hata durumunda yanıt döndürme
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync("Bir hata oluştu");

            }
        }
    }
    
}
