using App11.Database;
using App11.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace App11.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public OrderRepository(IConnectionFactory connectionFactory) =>
            _connectionFactory = connectionFactory;

        public Order GetOrderById(int orderId)
        {
            using var connection = _connectionFactory.CreateConnection();
            connection.Open();
            var result = connection.QueryFirstOrDefault<Order>("SELECT * FROM Orders WHERE OrderId = @OrderId", new { OrderId = orderId });
            return result!;
        }

        public IEnumerable<Order> GetOrders()
        {
            using var connection = _connectionFactory.CreateConnection();
            connection.Open();
            var result = connection.Query<Order>("SELECT * FROM Orders");
            return result;
        }

        public void PlaceOrder(Order order)
        {
            using var connection = _connectionFactory.CreateConnection();
            connection.Open();
            var sql = @"INSERT INTO Orders(OrderId, ProductId, Quantity, OrderDate) VALUES(@OrderId, @ProductId, @Quantity, @OrderDate)";
            var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add(new SqlParameter("@OrderId", order.OrderId));
            command.Parameters.Add(new SqlParameter("@ProductId", order.ProductId));
            command.Parameters.Add(new SqlParameter("@Quantity", order.Quantity));
            command.Parameters.Add(new SqlParameter("@OrderDate", order.OrderDate));
            var result = connection.Execute(new CommandDefinition(command.CommandText, command.Parameters));
        }
    }
}
