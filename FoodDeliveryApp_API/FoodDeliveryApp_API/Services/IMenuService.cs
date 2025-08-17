using FoodDeliveryApp_API.Models;

namespace FoodDeliveryApp_API.Services
{
    public interface IMenuService
    {
        public Menu Add(Menu menu);
        public Menu Update(Menu menu);
        public void Delete(Menu menu);
        public Menu? GetById(int id);
        public IEnumerable<Menu> GetAll();
        public List<MenuItem> GetMenuItemsById(List<int> id);
    }
}
