using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsApp11.Models;

namespace UnitTestsApp11.Repositories
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
