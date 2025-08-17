using FoodDeliveryApp_API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodDeliveryApp_API.DTOs
{
    public class UserDTO
    {
        [JsonIgnore]
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^91-[0-9]{10}$", ErrorMessage = "Phone number format is incorrect!")]
        public string UserPhone { get; set; }
        [EmailAddress(ErrorMessage = "Email format is incorrect!")]
        public string? UserEmail { get; set; }
        [Required(ErrorMessage = "Password is incorrect!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
