using Azure.Core;
using FoodDeliveryApp_API.Data;
using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FoodAppDBContext _dbContext;
        public UserRepository(FoodAppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }
        public User Update(User user)
        {
            var existing = _dbContext.Users.Include(u=>u.UserRole).FirstOrDefault(u => u.UserId.Equals(user.UserId));
            if (existing == null)
                return user;

            UpdateUser(existing, user);

            if (existing is Customer customer && user is Customer customer2)
            {
                customer.Address = customer2.Address;
                customer.State = customer2.State;
                customer.Pincode = customer2.Pincode;
                customer.city = customer2.city;
            }

            if(existing is DeliveryPartner partner && user is DeliveryPartner partner2)
            {
                partner.VehicleNumber = partner2.VehicleNumber;
            }

            _dbContext.SaveChanges();
            return user;
        }
        public void Delete(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }
        public User? GetById(int id)
        {
            return _dbContext.Users.Include(u => u.UserRole).FirstOrDefault(u => u.UserId.Equals(id));
        }
        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users.Include(u => u.UserRole).ToList();
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.Include(u => u.UserRole).Include(u=>u.Orders).ToList();
        }
        public IEnumerable<DeliveryPartner> GetAllDeliveryPartners()
        {
            return _dbContext.DeliveryPartners.Include(u => u.UserRole).ToList();
        }

        private void UpdateUser(User existing, User user)
        {
            existing.UserFullName = user.UserFullName;
            existing.UserName = user.UserName;
            existing.UserPhone = user.UserPhone;
            existing.UserEmail = user.UserEmail;
            existing.Password = user.Password;
            existing.RoleId = user.RoleId;
        }
    }
}
