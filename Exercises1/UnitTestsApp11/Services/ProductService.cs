using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsApp11.Repositories;

namespace UnitTestsApp11.Services
{
    internal class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            if (product.Stock < 0)
                throw new ArgumentException("Stock cannot be negative.");

            _productRepository.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _productRepository.GetProductById(product.ProductId);
            if (existingProduct == null)
                throw new InvalidOperationException("Product not found.");

            if (product.Stock < 0)
                throw new ArgumentException("Stock cannot be negative.");

            _productRepository.UpdateProduct(product);
        }

        public IEnumerable<Product> GetAllProducts() => _productRepository.GetAllProducts();

        public Product GetProductById(int productId) => _productRepository.GetProductById(productId);

        public void DeleteProduct(int productId) => _productRepository.DeleteProduct(productId);
    }

}

