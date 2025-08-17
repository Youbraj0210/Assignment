using FoodDeliveryApp_API.Data;
using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly FoodAppDBContext _dbContext;
        public OrderItemRepository(FoodAppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public OrderItem Add(OrderItem item)
        {
            MenuItem? menuItem = _dbContext.MenuItems.FirstOrDefault(mi => mi.MenuItemId.Equals(item.MenuItemId));
            if (menuItem != null)
            {
                item.unitPrice = menuItem.MenuItemPrice * item.Quantity;
            }
            _dbContext.OrderItems.Add(item);
            _dbContext.SaveChanges();
            return item;
        }
        public OrderItem Update(OrderItem item)
        {
            OrderItem? existing = _dbContext.OrderItems.Include(o=>o.MenuItem).FirstOrDefault(oi=>oi.OrderItemId.Equals(item.OrderItemId));
            var menuItem = _dbContext.MenuItems.FirstOrDefault(mi => mi.MenuItemId == item.MenuItem.MenuItemId);
            if (existing != null)
            {
                existing.unitPrice = item.unitPrice;
                existing.Quantity = item.Quantity;
                existing.MenuItem = menuItem;
            }
            _dbContext.SaveChanges();
            return item;
        }
        public void Delete(OrderItem item)
        {
            _dbContext.OrderItems.Remove(item);
            _dbContext.SaveChanges();
        }
        public OrderItem? GetById(int id)
        {
            return _dbContext.OrderItems.Include(oi=>oi.MenuItem).FirstOrDefault(m => m.OrderItemId.Equals(id));
        }
        public IEnumerable<OrderItem> GetAll()
        {
            return _dbContext.OrderItems.Include(oi => oi.MenuItem).Include(oi => oi.MenuItem.Cuisine).ToList();
        }
    }
}
