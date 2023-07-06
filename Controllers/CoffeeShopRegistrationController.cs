using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class CoffeeShopRegistrationController : Controller
    { 
        private List<User> users = new List<User>();
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(User user)
        {
            return RedirectToAction("Summary", user);
        }

        public IActionResult Summary(User user)
         {
            return View(user);
         }

    }
}
