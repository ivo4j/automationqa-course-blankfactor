using App11.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App11.Controllers
{
    public class ProductController
    {

[ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAllProducts([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var products = _productRepository.GetAllProducts(pageNumber, pageSize);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                var product = _productRepository.GetProductById(id);
                if (product == null)
                    return NotFound($"Product with ID {id} not found.");

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                if (product == null)
                    return BadRequest("Product is null.");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid product data.");

                _productRepository.AddProduct(product);
                return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            try
            {
                if (product == null || product.ProductId != id)
                    return BadRequest("Product data is invalid.");

                var existingProduct = _productRepository.GetProductById(id);
                if (existingProduct == null)
                    return NotFound($"Product with ID {id} not found.");

                _productRepository.UpdateProduct(product);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var product = _productRepository.GetProductById(id);
                if (product == null)
                    return NotFound($"Product with ID {id} not found.");

                _productRepository.DeleteProduct(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

}
}
