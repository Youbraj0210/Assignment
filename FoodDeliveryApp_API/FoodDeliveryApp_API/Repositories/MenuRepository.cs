using FoodDeliveryApp_API.Data;
using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly FoodAppDBContext _dbContext;
        public MenuRepository(FoodAppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Menu Add(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }
        public Menu Update(Menu menu)
        {
            Menu? existing = _dbContext.Menus.FirstOrDefault(m=>m.MenuId.Equals(menu.MenuId));
            if (existing != null)
            {
                existing.MenuName = menu.MenuName;
                List<int> ids = menu.Items.Select(m=>m.MenuItemId).ToList();
                var menuItems = GetMenuItemsById(ids);
                existing.Items = menuItems;
            }
            _dbContext.SaveChanges();
            return existing;
        }
        public void Delete(Menu menu)
        {
            _dbContext.Menus.Remove(menu);
            _dbContext.SaveChanges();
        }
        public Menu? GetById(int id)
        {
            return _dbContext.Menus.Include(m => m.Items).FirstOrDefault(m => m.MenuId.Equals(id));
        }
        public IEnumerable<Menu> GetAll()
        {
            return _dbContext.Menus.Include(m=>m.Items).ToList();
        }
        public List<MenuItem> GetMenuItemsById(List<int> id)
        {
            var menuItems = _dbContext.MenuItems.Where(mi => id.Contains(mi.MenuItemId)).ToList();
            return menuItems;
        }
    }
}
