using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models.Data;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsList productsList;
        public ProductController(IProductsList productsList)
        {
            this.productsList = productsList;
        }
        public IActionResult Index(int id)
        {
            return View(productsList.TryGetProduct(id));
        }
    }
}
