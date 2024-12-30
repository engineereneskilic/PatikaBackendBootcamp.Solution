using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Cryptography.X509Certificates;

namespace _14.week_02_AuthorizationFilters.Filters
{
    public class ApiKeyAuthorizationFilterAttribute : Attribute,IAuthorizationFilter
    {
        private const string ApiKeyHeaderName = "X-Api-Key";
        private const string ApiKey = "ApiKeyTest";

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName,out var potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            if(ApiKey.Equals(potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

           
            

        }
    }
}
