using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Repositories;

namespace FoodDeliveryApp_API.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _repository;
        public MenuItemService(IMenuItemRepository repository)
        {
            _repository = repository;
        }
        public MenuItem Add(MenuItem item)
        {
            return _repository.Add(item);
        }
        public MenuItem Update(MenuItem item)
        {
            return _repository.Update(item);
        }
        public void Delete(MenuItem item)
        {
            _repository.Delete(item);
        }
        public MenuItem? GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<MenuItem> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
