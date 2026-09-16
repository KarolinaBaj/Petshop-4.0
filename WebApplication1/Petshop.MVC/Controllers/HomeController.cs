using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WebApplication1.Petshop.MVC.Models;

namespace WebApplication1.Petshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("~/Petshop.MVC/Views/Home/Index.cshtml");
        }

        public IActionResult Privacy()
        {
            return View("~/Petshop.MVC/Views/Home/Privacy.cshtml" );
        }

        public IActionResult LoginStrana()
        {
            return View("~/Petshop.MVC/Views/Home/loginstrana.cshtml");
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
