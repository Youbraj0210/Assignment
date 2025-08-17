using FoodDeliveryApp_API.Models;

namespace FoodDeliveryApp_API.Services
{
    public interface IOrderService
    {
        public Order Add(Order order);
        public Order Update(Order order);
        public void Delete(Order order);
        public Order? GetById(int id);
        public IEnumerable<Order> GetAll();
        public List<OrderItem> GetOrderItemsById(List<int> id);
    }
}
