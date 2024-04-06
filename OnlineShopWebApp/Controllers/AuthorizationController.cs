using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models.UserClasses;

namespace OnlineShopWebApp.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Auth()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Auth(UserSinging userSinging)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
