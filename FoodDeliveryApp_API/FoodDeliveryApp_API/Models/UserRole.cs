using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp_API.Models
{
    public enum Role { ADMIN, CUSTOMER, DELIVERY_PARTNER }
    public class UserRole
    {
        [Key]
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Role is Required!")]
        public Role Role { get; set; }
    }
}
