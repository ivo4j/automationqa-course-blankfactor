using App11.Models;
using App11.Repositories;

namespace UnitTestsApp11.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public void PlaceOrder(Order order)
        {
            var product = _productRepository.GetProductById(order.ProductId);
            if (product == null)
                throw new InvalidOperationException("Product not found.");

            if (product.Stock < order.Quantity)
                throw new InvalidOperationException("Insufficient stock.");

            _orderRepository.PlaceOrder(order);

            product.Stock -= order.Quantity;
            _productRepository.UpdateProduct(product);
        }

        public IEnumerable<Order> GetOrders() => _orderRepository.GetOrders();

        public Order GetOrderById(int orderId) => _orderRepository.GetOrderById(orderId);
    }
}
