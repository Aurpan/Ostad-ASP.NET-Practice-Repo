using Microsoft.AspNetCore.Mvc.Filters;

namespace LibraryManagementMVC.Filters
{
    public class CustomResourceFilter : Attribute, IResourceFilter, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"CustomResourceFilter: OnResourceExecuted of Controller: {context.RouteData.Values["controller"]}, Action: {context.RouteData.Values["action"]}");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"CustomResourceFilter: OnResourceExecuting of Controller: {context.RouteData.Values["controller"]}, Action: {context.RouteData.Values["action"]}");
        }
    }
}
