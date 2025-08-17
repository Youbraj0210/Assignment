using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp_API.Models
{
    public class Customer : User
    {
        [Required(ErrorMessage = "City is Required!")]
        public string city { get; set; }
        public string State { get; set; } = "Maharashtra";
        [Required(ErrorMessage = "Pincode is Required")]
        [RegularExpression("^[0-9]{6}$",ErrorMessage ="Pincode format is incorrect!")]
        public int Pincode {  get; set; }
        [Required(ErrorMessage = "Address is Required!")]
        public string Address { get; set; } 
        public IEnumerable<Order>? Orders { get; set; }
    }
}
