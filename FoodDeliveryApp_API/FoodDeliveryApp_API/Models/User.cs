using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp_API.Models
{
    public class User
    {
        [Key]
        public int UserId {  get; set; }
        [Required(ErrorMessage = "Full Name is Required!")]
        public string UserFullName {  get; set; }
        [Required(ErrorMessage = "UserName is Required!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^91-[0-9]{10}$",ErrorMessage = "Phone number format is incorrect!")]
        public string UserPhone {  get; set; }
        [EmailAddress(ErrorMessage = "Email format is incorrect!")]
        public string? UserEmail { get; set; }
        [Required(ErrorMessage = "Password is incorrect!")]
        [DataType(DataType.Password)]
        public string Password {  get; set; }
        [DataType(DataType.Date)]
        public DateTime JoinDate {  get; set; } = DateTime.Now.Date;
        [ForeignKey("UserRole")]
        public int RoleId {  get; set; }
        public virtual UserRole? UserRole { get; set; }
    }
}
