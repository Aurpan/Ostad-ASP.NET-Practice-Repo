using Microsoft.AspNetCore.Mvc.Filters;

namespace LibraryManagementMVC.Filters
{
    public class CustomAuthFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Console.WriteLine($"CustomAuthFilter: OnAuthorization of Controller: {context.RouteData.Values["controller"]}, Action: {context.RouteData.Values["action"]}");
        }
    }
}
