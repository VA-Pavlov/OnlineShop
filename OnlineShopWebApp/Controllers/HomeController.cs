using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models.Data;
using OnlineShopWebApp.Models.UserClasses;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsList productsList;
        public HomeController(IProductsList productsList)
        {
            this.productsList = productsList;
        }

        public IActionResult Index()
        {
            return View(productsList.GetProducts());
        }
    }
}
