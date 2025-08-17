
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp_API.Models
{
    public class LoginResponseViewModel
    {
        [Required(ErrorMessage = "IsSuccess is Required")]
        public bool IsSuccess {  get; set; }
        public User? User { get; set; }
        public string Token {  get; set; }

    }
}
