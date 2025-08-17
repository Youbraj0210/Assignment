using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Repositories;

namespace FoodDeliveryApp_API.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _repository;
        public MenuService(IMenuRepository repository)
        {
            _repository = repository;
        }
        public Menu Add(Menu menu)
        {
            return _repository.Add(menu);
        }
        public Menu Update(Menu menu)
        {
            return _repository.Update(menu);
        }
        public void Delete(Menu menu)
        {
            _repository.Delete(menu);
        }
        public Menu? GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<Menu> GetAll()
        {
            return _repository.GetAll();
        }
        public List<MenuItem> GetMenuItemsById(List<int> id)
        {
            return _repository.GetMenuItemsById(id);
        }
    }
}
