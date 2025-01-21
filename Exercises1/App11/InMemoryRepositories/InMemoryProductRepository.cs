using App11.Models;
using App11.Repositories;

namespace App11.InMemoryRepositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
