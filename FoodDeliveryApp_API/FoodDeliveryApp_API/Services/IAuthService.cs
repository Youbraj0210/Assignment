using FoodDeliveryApp_API.Models;

namespace FoodDeliveryApp_API.Services
{
    public interface IAuthService
    {
        public LoginResponseViewModel Login(LoginViewModel usr);

    }
}
