using FoodDeliveryApp_API.Data;
using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FoodAppDBContext _dbContext;
        public OrderRepository(FoodAppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Order Add(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return order;
        }
        public Order Update(Order order)
        {
            Order? existing = _dbContext.Orders.Include(o=>o.Items).FirstOrDefault(o => o.OrderId.Equals(order.OrderId));
            if (existing != null)
            {
                existing.OrderDate = order.OrderDate;
                existing.CustomerId = order.CustomerId;
                existing.OrderTotalPrice = order.OrderTotalPrice;
                existing.discount = order.discount;
                List<int> ids = order.Items.Select(o=>o.OrderItemId).ToList();
                var orderItems= GetOrderItemsById(ids);
                existing.Items = orderItems;
            }
            _dbContext.SaveChanges();
            return existing;
        }
        public void Delete(Order order)
        {
            _dbContext.Orders.Remove(order);
            _dbContext.SaveChanges();
        }
        public Order? GetById(int id)
        {
            return _dbContext.Orders.Include(o=>o.Items).FirstOrDefault(m => m.OrderId.Equals(id));
        }
        public IEnumerable<Order> GetAll()
        {
            return _dbContext.Orders.Include(o=>o.Items).ToList();
        }
        public List<OrderItem> GetOrderItemsById(List<int> id)
        {
            var orderItems = _dbContext.OrderItems.Where(oi => id.Contains(oi.OrderItemId)).ToList();
            return orderItems;
        }
    }
}
