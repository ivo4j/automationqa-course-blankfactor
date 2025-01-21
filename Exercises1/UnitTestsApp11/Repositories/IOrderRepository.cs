using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsApp11.Models;

namespace UnitTestsApp11.Repositories
{
    internal interface IOrderRepository
    {
        void PlaceOrder(Order order);
        IEnumerable<Order> GetOrders();
        Order GetOrderById(int orderId);
    }
}
