using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public User Add(User user)
        {
            return _repository.Add(user);
        }
        public User Update(User user)
        {
            return _repository.Update(user);
        }
        public void Delete(User user)
        {
            _repository.Delete(user);
        }
        public User? GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.GetAllCustomers();
        }
        public IEnumerable<DeliveryPartner> GetAllDeliveryPartners()
        {
            return _repository.GetAllDeliveryPartners();
        }
    }
}
