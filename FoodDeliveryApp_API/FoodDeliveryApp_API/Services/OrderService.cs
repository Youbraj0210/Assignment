using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Repositories;

namespace FoodDeliveryApp_API.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }
        public Order Add(Order order)
        {
            return _repository.Add(order);
        }
        public Order Update(Order order)
        {
            return _repository.Update(order);
        }
        public void Delete(Order order)
        {
            _repository.Delete(order);
        }
        public Order? GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<Order> GetAll()
        {
            return _repository.GetAll();
        }
        public List<OrderItem> GetOrderItemsById(List<int> id)
        {
            return _repository.GetOrderItemsById(id);
        }
    }
}
