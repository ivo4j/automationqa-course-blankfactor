using App11.Models;

namespace App11.Repositories
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
        IEnumerable<Order> GetOrders();
        Order GetOrderById(int orderId);
    }
}
