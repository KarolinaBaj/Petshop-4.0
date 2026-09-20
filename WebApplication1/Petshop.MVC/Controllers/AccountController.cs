using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using WebApplication1.Petshop.DAL.Models;
using WebApplication1.Petshop.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;



namespace WebApplication1.Petshop.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly PetshopDBcontext _context;
        public AccountController(PetshopDBcontext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult signupstrana(User user)
        {


            if (_context.Users.Any(x => x.email == user.email))
            {
                ViewBag.Greska = "Email je vec registrovan";
                return Redirect("https://www.youtube.com/shorts/ynKyjrLmpHo");
            }
           
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
        
             }

           return RedirectToAction("LoginStrana","Home");

        }




            

        

        [HttpPost]
        public IActionResult LoginStrana(User user)
        {
            var korisnik = _context.Users.FirstOrDefault(x => x.email == user.email && x.lozinka == user.lozinka);

            if (korisnik == null)
            {

                ViewBag.Greska = "Pogresan email ili lozinka";
                return View("~/Petshop.MVC/Views/Home/loginstrana.cshtml");
            }
            return RedirectToAction("Index", "Home");
        }
        
    }
}
