using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action methods
        public IActionResult Index()
        {
            _logger.LogInformation("This is an Information Log from Home > Index!");
            _logger.LogDebug("This is an Debug Log from Home > Index!");
            _logger.LogError("This is an Error Log from Home > Index!");

            return View();
        }

        // Log levels => Trace, Debug, Information, Warning, Error, Critical
    }
}
