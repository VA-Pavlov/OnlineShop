using OnlineShopWebApp.Models.ProductClasses;

namespace OnlineShopWebApp.Models.Data
{
    public interface IProductsList
    {
        Product TryGetProduct(int id);
        public List<Product> GetProducts();
    }
}