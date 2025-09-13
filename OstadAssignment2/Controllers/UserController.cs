using Microsoft.AspNetCore.Mvc;

namespace OstadAssignment2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
