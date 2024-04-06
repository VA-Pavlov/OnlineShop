using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models.Data;
using OnlineShopWebApp.Models.OrderClasses;

namespace OnlineShopWebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IBagsList bagsList;
        private readonly IOrdersList ordersList;
        public OrderController(IBagsList bagsList, IOrdersList ordersList)
        {
            this.bagsList = bagsList;
            this.ordersList = ordersList;
        }
        public ActionResult Info()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Result(UserInfo user)
        {
            var order = new Order()
            {
                Id = Guid.NewGuid(),
                OrderItems = bagsList.TryGetByUserId(Constants.UserId).BagItems,
                User = user,
                СreatingTime = DateTime.Now,
                Status = OrderStatus.accepted
            };
            ordersList.Add(order);
            bagsList.Clear(Constants.UserId);
            return View();
        }
    }
}
