using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public interface IUserRepository
    {
        public User Add(User user);
        public User Update(User user);
        public void Delete(User user);
        public User? GetById(int id);
        public IEnumerable<User> GetAll();
        public IEnumerable<Customer> GetAllCustomers();
        public IEnumerable<DeliveryPartner> GetAllDeliveryPartners();
    }
}
