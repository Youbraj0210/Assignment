using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public interface IOrderRepository
    {
        public Order Add(Order order);
        public Order Update(Order order);
        public void Delete(Order order);
        public Order? GetById(int id);
        public IEnumerable<Order> GetAll();
        public List<OrderItem> GetOrderItemsById(List<int> id);
    }
}
