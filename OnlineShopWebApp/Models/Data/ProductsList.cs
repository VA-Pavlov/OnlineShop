using OnlineShopWebApp.Models.ProductClasses;

namespace OnlineShopWebApp.Models.Data
{
    public class ProductsList : IProductsList
    {
        private List<Product> products = new List<Product>()
        {
            new Product("Ликийская тропа","image1.png","Турция",10,new DateTime(2024,4,17),new DateTime(2024,4,27),RoutesDifficulty.Medium,50000,15,5,ProductStatus.active),
            new Product("Кемп в Карелии","image12.png","Карелия",3,new DateTime(2024,5,20),new DateTime(2024,5,23),RoutesDifficulty.Easy,14000,20,0,ProductStatus.active),
            new Product("Териберка","image1.png","Мурманская област",4,new DateTime(2024,3,20),new DateTime(2024,3,23),RoutesDifficulty.Easy,23000,20,18,ProductStatus.active),
            new Product("Трэил по Грузии","image12.png","Грузия",3,new DateTime(2024,5,20),new DateTime(2024,5,23),RoutesDifficulty.Easy,14000,20,0,ProductStatus.active),
            new Product("Летний Байкал","image1.png","Байкал",10,new DateTime(2024,4,17),new DateTime(2024,4,27),RoutesDifficulty.Medium,50000,15,5,ProductStatus.active),
            new Product("Кемп в Карелии","image12.png","Карелия",3,new DateTime(2024,5,20),new DateTime(2024,5,23),RoutesDifficulty.Easy,14000,20,0,ProductStatus.active),
            new Product("Ликийская тропа","image1.png","Турция",10,new DateTime(2024,4,17),new DateTime(2024,4,27),RoutesDifficulty.Medium,50000,15,5,ProductStatus.active),
            new Product("Кемп в Карелии","image12.png","Карелия",3,new DateTime(2024,5,20),new DateTime(2024,5,23),RoutesDifficulty.Easy,14000,20,0,ProductStatus.active),
            new Product("Ликийская тропа","image1.png","Турция",10,new DateTime(2024,4,17),new DateTime(2024,4,27),RoutesDifficulty.Medium,50000,15,5,ProductStatus.active),
            new Product("Кемп в Карелии","image12.png","Карелия",3,new DateTime(2024,5,20),new DateTime(2024,5,23),RoutesDifficulty.Easy,14000,20,0,ProductStatus.active),
            new Product("Ликийская тропа","image1.png","Турция",10,new DateTime(2024,4,17),new DateTime(2024,4,27),RoutesDifficulty.Medium,50000,15,5,ProductStatus.active),
            new Product("Кемп в Карелии","image12.png","Карелия",3,new DateTime(2024,5,20),new DateTime(2024,5,23),RoutesDifficulty.Easy,14000,20,0,ProductStatus.active),
            new Product("Ликийская тропа","image1.png","Турция",10,new DateTime(2024,4,17),new DateTime(2024,4,27),RoutesDifficulty.Medium,50000,15,5,ProductStatus.active),
            new Product("Кемп в Карелии","image12.png","Карелия",3,new DateTime(2024,5,20),new DateTime(2024,5,23),RoutesDifficulty.Easy,14000,20,0,ProductStatus.active)
        };

        public Product TryGetProduct(int id)
        {
            return products[id - 1];
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
