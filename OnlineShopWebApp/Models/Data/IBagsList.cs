using OnlineShopWebApp.Models.BagClasses;
using OnlineShopWebApp.Models.ProductClasses;

namespace OnlineShopWebApp.Models.Data
{
    public interface IBagsList
    {
        void Add(Product product, string userId);
        void Remove(Product product, string userId);
        void Clear(string userId);
		Bag TryGetByUserId(string userId);
    }
}