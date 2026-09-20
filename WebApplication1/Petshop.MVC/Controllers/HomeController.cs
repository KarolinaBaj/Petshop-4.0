using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WebApplication1.Petshop.DAL.Models;
using WebApplication1.Petshop.DAL;
using WebApplication1.Petshop.MVC.Models;

namespace WebApplication1.Petshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly PetshopDBcontext _context;
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(PetshopDBcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> listaProizvoda = _context.Products.ToList();
            return View("~/Petshop.MVC/Views/Home/Index.cshtml", listaProizvoda);
        }

        public IActionResult Privacy()
        {
            return View("~/Petshop.MVC/Views/Home/Privacy.cshtml" );
        }

        public IActionResult LoginStrana()
        {
            return View("~/Petshop.MVC/Views/Home/loginstrana.cshtml");
        }


        public IActionResult signupstrana()
        {
            return View("~/Petshop.MVC/Views/Home/signupstrana.cshtml");
        }

        public IActionResult Proizvod()
        {
            return View("~/Petshop.MVC/Views/Home/Proizvod.cshtml");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
