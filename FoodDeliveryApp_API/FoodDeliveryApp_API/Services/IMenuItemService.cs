using FoodDeliveryApp_API.Models;

namespace FoodDeliveryApp_API.Services
{
    public interface IMenuItemService
    {
        public MenuItem Add(MenuItem item);
        public MenuItem Update(MenuItem item);
        public void Delete(MenuItem item);
        public MenuItem? GetById(int id);
        public IEnumerable<MenuItem> GetAll();
    }
}
