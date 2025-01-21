using App11.Models;
using App11.Repositories;

namespace App11.InMemoryRepositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        public Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
