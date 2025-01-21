using App11.Models;
using App11.Repositories;

namespace UnitTestsApp11.Services
{
    public class ProductService
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
        }

        public IEnumerable<Product> GetAllProducts() => _productRepository.GetAllProducts();

        public Product GetProductById(int productId) => _productRepository.GetProductById(productId);

        public void DeleteProduct(int productId) => _productRepository.DeleteProduct(productId);
    }

}