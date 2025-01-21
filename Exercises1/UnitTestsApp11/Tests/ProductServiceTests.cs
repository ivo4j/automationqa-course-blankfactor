using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsApp11.Repositories;
using UnitTestsApp11.Services;
using Xunit;

namespace UnitTestsApp11.Tests
{
    internal class ProductServiceTests
    {
        [Fact]
        public void GetAllProducts_ReturnsCorrectData()
        {
            // Arrange
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(repo => repo.GetAllProducts()).Returns(new List<Product>
            {
                new Product { ProductId = 1, Name = "Laptop", Price = 1000m, Stock = 10 },
                new Product { ProductId = 2, Name = "Phone", Price = 500m, Stock = 20 }
            });

            var productService = new ProductService(mockProductRepository.Object);

            // Act
            var products = productService.GetAllProducts();

            // Assert
            Assert.NotNull(products);
            Assert.Equal(2, products.Count());
        }

        [Fact]
        public void AddProduct_ThrowsException_WhenStockIsNegative()
        {
            // Arrange
            var mockProductRepository = new Mock<IProductRepository>();
            var productService = new ProductService(mockProductRepository.Object);

            var invalidProduct = new Product { Name = "Tablet", Price = 300m, Stock = -5 };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => productService.AddProduct(invalidProduct));
        }

        [Fact]
        public void UpdateProduct_UpdatesCorrectly()
        {
            // Arrange
            var mockProductRepository = new Mock<IProductRepository>();
            var existingProduct = new Product { ProductId = 1, Name = "Laptop", Price = 1000m, Stock = 10 };

            mockProductRepository.Setup(repo => repo.GetProductById(1)).Returns(existingProduct);

            var productService = new ProductService(mockProductRepository.Object);

            // Act
            existingProduct.Price = 1200m;
            productService.UpdateProduct(existingProduct);

            // Assert
            mockProductRepository.Verify(repo => repo.UpdateProduct(existingProduct), Times.Once);
        }
    }
}
