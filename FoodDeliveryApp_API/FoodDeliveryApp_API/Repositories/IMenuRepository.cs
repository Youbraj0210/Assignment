using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public interface IMenuRepository
    {
        public Menu Add(Menu menu);
        public Menu Update(Menu menu);
        public void Delete(Menu menu);
        public Menu? GetById(int id);
        public IEnumerable<Menu> GetAll();
        public List<MenuItem> GetMenuItemsById(List<int> id);
    }
}
