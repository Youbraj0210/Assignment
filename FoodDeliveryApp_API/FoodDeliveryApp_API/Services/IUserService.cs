using FoodDeliveryApp_API.Models;

namespace FoodDeliveryApp_API.Services
{
    public interface IUserService
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
