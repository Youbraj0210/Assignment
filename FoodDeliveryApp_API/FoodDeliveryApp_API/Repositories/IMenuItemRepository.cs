using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public interface IMenuItemRepository
    {
        public MenuItem Add(MenuItem item);
        public MenuItem Update(MenuItem item);
        public void Delete(MenuItem item);
        public MenuItem? GetById(int id);
        public IEnumerable<MenuItem> GetAll();
    }
}
