using FoodDeliveryApp_API.Models;

namespace FoodDeliveryApp_API.Repositories
{
    public interface IAuthRepository
    {
        public LoginResponseViewModel Login(LoginViewModel usr);

    }
}
