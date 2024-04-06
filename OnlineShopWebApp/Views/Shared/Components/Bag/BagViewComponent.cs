using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models.Data;

namespace OnlineShopWebApp.Views.Shared.Components.Bag
{
    public class BagViewComponent : ViewComponent
    {
        private readonly IBagsList bagsList;
        public BagViewComponent(IBagsList bagsList)
        {
            this.bagsList = bagsList;
        }

        public IViewComponentResult Invoke()
        {
            var bag = bagsList.TryGetByUserId(Constants.UserId);
            var amount = (bag?.Amount ?? 0) > 0 ? bag.Amount.ToString() : "";
            return View("Bag", amount);
        }
    }
}
