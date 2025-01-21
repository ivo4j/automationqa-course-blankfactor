using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsApp11.Repositories;

namespace UnitTestsApp11.InMemoryRepositories
{
    internal class InMemoryProductRepository : Repositories.IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public IEnumerable<Product> GetAllProducts() => _products;
        public Product GetProductById(int productId) => _products.Find(p => p.ProductId == productId);
        public void AddProduct(Product product) { product.ProductId = _products.Count + 1; _products.Add(product); }
        public void UpdateProduct(Product product)
        {
            var index = _products.FindIndex(p => p.ProductId == product.ProductId);
            if (index >= 0) _products[index] = product;
        }
        public void DeleteProduct(int productId) => _products.RemoveAll(p => p.ProductId == productId);
    }
}
