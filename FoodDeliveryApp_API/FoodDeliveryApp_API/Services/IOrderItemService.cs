using FoodDeliveryApp_API.Models;

namespace FoodDeliveryApp_API.Services
{
    public interface IOrderItemService
    {
        public OrderItem Add(OrderItem item);
        public OrderItem Update(OrderItem item);
        public void Delete(OrderItem item);
        public OrderItem? GetById(int id);
        public IEnumerable<OrderItem> GetAll();
    }
}
