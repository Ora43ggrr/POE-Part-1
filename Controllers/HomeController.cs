using System.Diagnostics; // Provides classes for system diagnostics
using Microsoft.AspNetCore.Mvc; // Provides MVC functionality
using POE_Part_1.Models; // References application models

namespace POE_Part_1.Controllers // Defines the controller namespace
{
    public class HomeController : Controller // Main controller class inheriting from Controller
    {
        private readonly ILogger<HomeController> _logger; // Logger instance for tracking

        public HomeController(ILogger<HomeController> logger) // Constructor with dependency injection
        {
            _logger = logger; // Initializes the logger
        }

        public IActionResult Index() // Action method for the home page
        {
            return View(); // Returns the Index view
        }

        public IActionResult Privacy() // Action method for the privacy policy page
        {
            return View(); // Returns the Privacy view
        }

        public IActionResult Register() // Action method for the registration page
        {
            return View(); // Returns the Register view
        }

        public IActionResult Dashboard() // Action method for the dashboard page
        {
            return View(); // Returns the Dashboard view
        }
        
        public IActionResult Claims() // Action method for the claims page
        {
            return View(); // Returns the Claims view
        }
        
        public IActionResult SubmitClaim() // Action method for the claim submission page
        {
            return View(); // Returns the SubmitClaim view
        }
        
        public IActionResult Documents() // Action method for the documents page
        {
            return View(); // Returns the Documents view
        }
        
        public IActionResult ReviewClaims() // Action method for the claims review page
        {
            return View(); // Returns the ReviewClaims view
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // Disables caching for this action
        public IActionResult Error() // Action method for error page
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); // Returns error view with request ID
        }
        public IActionResult Notifications()
        {
            return View();
        }
    }
}
