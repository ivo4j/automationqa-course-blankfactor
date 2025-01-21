using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsApp11.Models;

namespace UnitTestsApp11.InMemoryRepositories
{
    internal class InMemoryOrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>();

        public void PlaceOrder(Order order) { order.OrderId = _orders.Count + 1; _orders.Add(order); }
        public IEnumerable<Order> GetOrders() => _orders;
        public Order GetOrderById(int orderId) => _orders.Find(o => o.OrderId == orderId);
    }
}
