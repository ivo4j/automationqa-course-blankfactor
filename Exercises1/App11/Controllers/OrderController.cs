using App11.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App11.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderController(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders = _orderRepository.GetOrders();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            try
            {
                var order = _orderRepository.GetOrderById(id);
                if (order == null)
                    return NotFound($"Order with ID {id} not found.");

                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] Order order)
        {
            try
            {
                if (order == null)
                    return BadRequest("Order is null.");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid order data.");

                var product = _productRepository.GetProductById(order.ProductId);
                if (product == null)
                    return NotFound($"Product with ID {order.ProductId} not found.");

                if (product.Stock < order.Quantity)
                    return BadRequest("Insufficient stock for the product.");

                _orderRepository.PlaceOrder(order);

                // Reduce product stock
                product.Stock -= order.Quantity;
                _productRepository.UpdateProduct(product);

                return CreatedAtAction(nameof(GetOrderById), new { id = order.OrderId }, order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
