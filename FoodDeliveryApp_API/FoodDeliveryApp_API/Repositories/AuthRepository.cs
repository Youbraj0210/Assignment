using FoodDeliveryApp_API.Data;
using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly FoodAppDBContext _dbContext;
        public AuthRepository(FoodAppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public LoginResponseViewModel Login(LoginViewModel usr)
        {
            User? user = _dbContext.Users.Include(u=>u.UserRole).FirstOrDefault((u) => u.UserName.Equals(usr.UserName) && u.Password.Equals(usr.Password));
            LoginResponseViewModel response;
            if (user == null)
            {
                response = new LoginResponseViewModel
                {
                    IsSuccess = false,
                    User = null,
                    Token = ""
                };
                return response;
            }
            response = new LoginResponseViewModel
            {
                IsSuccess = true,
                User = user,
                Token = ""
            };
            return response;

        }
    }
}
