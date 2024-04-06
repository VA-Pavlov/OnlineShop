using OnlineShopWebApp.Models.ProductClasses;

namespace OnlineShopWebApp.Models.BagClasses
{
    public class BagItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal Cost
        {
            get
            {
                return Product.Cost * Amount;
            }
        }
    }
}
