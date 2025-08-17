using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public interface IOrderItemRepository
    {
        public OrderItem Add(OrderItem item);
        public OrderItem Update(OrderItem item);
        public void Delete(OrderItem item);
        public OrderItem? GetById(int id);
        public IEnumerable<OrderItem> GetAll();
    }
}
