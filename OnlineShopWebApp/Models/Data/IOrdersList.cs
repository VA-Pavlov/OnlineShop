using OnlineShopWebApp.Models.OrderClasses;

namespace OnlineShopWebApp.Models.Data
{
    public interface IOrdersList
    {
        void Add(Order order);
        List<Order> GetOrders();
    }
}