namespace OnlineShopWebApp.Models.BagClasses
{
    public class Bag
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<BagItem> BagItems { get; set; }
        public decimal Cost
        {
            get
            {
                return BagItems.Sum(x => x.Cost);
            }
        }
        public int Amount
        {
            get
            {
                return BagItems.Sum(x => x.Amount);
            }
        }
    }
}
