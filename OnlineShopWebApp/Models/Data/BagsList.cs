
using OnlineShopWebApp.Models.BagClasses;
using OnlineShopWebApp.Models.ProductClasses;

namespace OnlineShopWebApp.Models.Data
{
    public class BagsList : IBagsList
    {
        private List<Bag> bags = new List<Bag>();

        public Bag TryGetByUserId(string userId)
        {
            return bags.FirstOrDefault(x => x.UserId == userId);
        }

        public void Add(Product product, string userId)
        {
            var bag = TryGetByUserId(userId);
            if (bag == null)
            {
                bag = new Bag
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    BagItems = new List<BagItem>
                    {
                        new BagItem
                        {
                            Id = Guid.NewGuid(),
                            Amount = 1,
                            Product = product
                        }
                    }
                };
                bags.Add(bag);
            }
            else
            {
                var findProduct = bag.BagItems.FirstOrDefault(x => x.Product == product);
                if (findProduct != null)
                {
                    findProduct.Amount++;
                }
                else
                {
                    bag.BagItems.Add(
                        new BagItem
                        {
                            Id = Guid.NewGuid(),
                            Amount = 1,
                            Product = product
                        });
                }
            }
        }

        public void Remove(Product product, string userId)
        {
			var bag = TryGetByUserId(userId);
			var findProduct = bag.BagItems.FirstOrDefault(x => x.Product == product);
			findProduct.Amount--;
            if(findProduct.Amount == 0)
                bag.BagItems.Remove(findProduct);
        }
		public void Clear(string userId)
		{
			var bag = TryGetByUserId(userId);
            bag.BagItems = new List<BagItem>();
		}
	}
}
