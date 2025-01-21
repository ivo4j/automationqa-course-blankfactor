using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsApp11.Models;
using UnitTestsApp11.Repositories;
using UnitTestsApp11.Services;
using Xunit;

namespace UnitTestsApp11.Tests
{
    public class FakeProductRepository : IProductRepository
    {
        public void DeleteProduct(int productId)
        {
        }

        void IProductRepository.AddProduct(Product product)
        {
        }

        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            yield return new();
        }

        Product IProductRepository.GetProductById(int productId)
        {
            return new();
        }

        void IProductRepository.UpdateProduct(Product product)
        {

        }
    }

    public class OrderServiceTests
    {
        [Fact]
        public void PlaceOrder_ReducesStockCorrectly()
        {
            // Arrange
            var mockProductRepository = new Mock<IProductRepository>();
            var mockOrderRepository = new Mock<IOrderRepository>();

            var product = new Product { ProductId = 1, Name = "Laptop", Price = 1000m, Stock = 10 };
            mockProductRepository.Setup(repo => repo.GetProductById(1)).Returns(product);

            var orderService = new OrderService(mockOrderRepository.Object, mockProductRepository.Object);

            // Act
            var order = new Order { ProductId = 1, Quantity = 2, OrderDate = DateTime.Now };
            orderService.PlaceOrder(order);

            // Assert
            Assert.Equal(8, product.Stock);
            mockProductRepository.Verify(repo => repo.UpdateProduct(product), Times.Once);
            mockOrderRepository.Verify(repo => repo.PlaceOrder(order), Times.Once);
        }

        [Fact]
        public void PlaceOrder_ThrowsException_WhenStockIsInsufficient()
        {
            // Arrange
            var mockProductRepository = new Mock<IProductRepository>();
            var mockOrderRepository = new Mock<IOrderRepository>();

            var product = new Product { ProductId = 1, Name = "Laptop", Price = 1000m, Stock = 1 };
            mockProductRepository.Setup(repo => repo.GetProductById(1)).Returns(product);

            var orderService = new OrderService(mockOrderRepository.Object, mockProductRepository.Object);

            var order = new Order { ProductId = 1, Quantity = 2, OrderDate = DateTime.Now };

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => orderService.PlaceOrder(order));
        }
    }
}
