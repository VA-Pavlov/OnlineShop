using OnlineShopWebApp.Models.BagClasses;

namespace OnlineShopWebApp.Models.OrderClasses
{
    public class Order
    {
        public Guid Id { get; set; }
        public List<BagItem> OrderItems { get; set; }
        public DateTime СreatingTime { get; set; }
        public UserInfo User { get; set; }
        public OrderStatus Status {  get; set; }
    }
}