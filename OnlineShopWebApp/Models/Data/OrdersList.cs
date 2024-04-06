using OnlineShopWebApp.Models.BagClasses;
using OnlineShopWebApp.Models.OrderClasses;
using OnlineShopWebApp.Models.ProductClasses;

namespace OnlineShopWebApp.Models.Data
{
    public class OrdersList : IOrdersList
    {
        private List<Order> orders = new();
        public List<Order> GetOrders() { return orders; }
        public void Add(Order order)
        {
            orders.Add(order);
        }
    }
}
