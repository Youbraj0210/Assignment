using FoodDeliveryApp_API.Data;
using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly FoodAppDBContext _dbContext;
        public MenuItemRepository(FoodAppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public MenuItem Add(MenuItem item)
        {
            _dbContext.MenuItems.Add(item);
            _dbContext.SaveChanges();
            return item;
        }
        public MenuItem Update(MenuItem item)
        {
            MenuItem? existingItem = _dbContext.MenuItems.FirstOrDefault(mi => mi.MenuItemId.Equals(item.MenuItemId));
            if (existingItem != null)
            {
                existingItem.MenuItemName = item.MenuItemName;
                existingItem.MenuItemDescription = item.MenuItemDescription;
                existingItem.MenuItemPrice = item.MenuItemPrice;
                existingItem.IsAvailable = item.IsAvailable;
                existingItem.CuisineId = item.CuisineId;
                _dbContext.SaveChanges();
            }
            return item;
        }
        public void Delete(MenuItem item)
        {
            _dbContext.MenuItems.Remove(item);
            _dbContext.SaveChanges();
        }
        public MenuItem? GetById(int id)
        {
            return _dbContext.MenuItems.Include(mi => mi.Menus).FirstOrDefault(m => m.MenuItemId.Equals(id));
        }
        public IEnumerable<MenuItem> GetAll()
        {
            return _dbContext.MenuItems.Include(mi=>mi.Menus).ToList();
        }
    }
}
