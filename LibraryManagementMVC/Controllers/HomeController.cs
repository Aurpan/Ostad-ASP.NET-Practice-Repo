using System.Diagnostics;
using LibraryManagementMVC.Models;
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
            return View();
        }
    }
}
