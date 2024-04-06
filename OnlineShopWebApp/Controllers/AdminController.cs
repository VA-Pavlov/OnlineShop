using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models.Data;

namespace OnlineShopWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IOrdersList ordersList;
        private readonly IProductsList productsList;
        public AdminController(IOrdersList ordersList, IProductsList productsList)
        {
            this.ordersList = ordersList;
            this.productsList = productsList;
        }
        public ActionResult Orders()
        {
            return View(ordersList.GetOrders());
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult Roles()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View(productsList.GetProducts());
        }

    }
}
