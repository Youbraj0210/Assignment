using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FoodDeliveryApp_API.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        public AuthService(IAuthRepository authRepository)
        {
            _repository = authRepository;
        }
        public LoginResponseViewModel Login(LoginViewModel usr)
        {
            var response = _repository.Login(usr);
            if (response.IsSuccess)
            {
                response.Token = GenerateJwtToken(response.User);
            }
            return response;
        }

        private string GenerateJwtToken(User user)
        {
            var config = new ConfigurationManager();
            config.AddJsonFile("appsettings.json");
            var secreteKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["ConnectionStrings:JwtString"]));
            var signingCredentials = new SigningCredentials(secreteKey,SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email,user.UserEmail),
                new Claim(ClaimTypes.Role,user.UserRole.Role.ToString()),
                new Claim("MyClaim",user.UserPhone),
            };
            var tokenOptions = new JwtSecurityToken(
                    issuer: "https://localhost:7237",
                    audience: "https://localhost:7237",
                    signingCredentials: signingCredentials,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30)
                );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return tokenString;
        }

    }
}
