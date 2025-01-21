using App11.Database;
using App11.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace App11.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public ProductRepository(IConnectionFactory connectionFactory) =>
            _connectionFactory = connectionFactory;

        public void AddProduct(Product product)
        {
            var connection = _connectionFactory.CreateConnection();
            var sql = @"INSERT INTO Orders(ProductId, Name, Price, Stock) VALUES(@ProductId, @Name, @Price, @Stock)";
            var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add(new SqlParameter("@ProductId", product.ProductId));
            command.Parameters.Add(new SqlParameter("@Name", product.Name));
            command.Parameters.Add(new SqlParameter("@Price", product.Price));
            command.Parameters.Add(new SqlParameter("@Stock", product.Stock));
            var result = connection.Execute(new CommandDefinition(command.CommandText, command.Parameters));
        }

        public void DeleteProduct(int productId)
        {
            var connection = _connectionFactory.CreateConnection();
            var sql = @"DELETE FROM Orders WHERE ProductId = @ProductId";
            var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add(new SqlParameter("@ProductId", productId));
            var result = connection.Execute(new CommandDefinition(command.CommandText, command.Parameters));
        }

        public IEnumerable<Product> GetAllProducts()
        {
            using var connection = _connectionFactory.CreateConnection();
            connection.Open();
            var result = connection.Query<Product>("SELECT * FROM Product");
            return result;
        }

        public Product GetProductById(int productId)
        {
            using var connection = _connectionFactory.CreateConnection();
            connection.Open();
            var result = connection.QueryFirstOrDefault<Product>("SELECT * FROM Product");
            return result!;
        }

        public void UpdateProduct(Product product)
        {
        }
    }
}
