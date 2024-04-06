using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models.Data;

namespace OnlineShopWebApp.Controllers
{
    public class BagController : Controller
    {
        private readonly IProductsList productsList;
        private readonly IBagsList bagsList;
        public BagController(IProductsList productsList, IBagsList bagsList)
        {
            this.productsList = productsList;
            this.bagsList = bagsList;
        }
        public IActionResult Index()
        {
            var bag = bagsList.TryGetByUserId(Constants.UserId);
            return View(bag);
        }

        public IActionResult Add(int productId)
        {
            var product = productsList.TryGetProduct(productId);
            bagsList.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int productId)
        {
            var product = productsList.TryGetProduct(productId);
            bagsList.Remove(product, Constants.UserId);
            return RedirectToAction("Index");
        }
		public IActionResult Clear()
		{
			bagsList.Clear(Constants.UserId);
			return RedirectToAction("Index");
		}
	}
}
