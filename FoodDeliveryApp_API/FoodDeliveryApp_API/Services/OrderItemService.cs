using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Repositories;

namespace FoodDeliveryApp_API.Services
{
    public class OrderItemService : IOrderItemService   
    {
        private readonly IOrderItemRepository _repository;
        public OrderItemService(IOrderItemRepository repository)
        {
            _repository = repository;
        }
        public OrderItem Add(OrderItem item)
        {
            return _repository.Add(item);
        }
        public OrderItem Update(OrderItem item)
        {
            return _repository.Update(item);
        }
        public void Delete(OrderItem item)
        {
            _repository.Delete(item);
        }
        public OrderItem? GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<OrderItem> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
