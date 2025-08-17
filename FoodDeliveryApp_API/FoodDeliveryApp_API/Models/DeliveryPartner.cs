using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp_API.Models
{
    public class DeliveryPartner :User
    {
        [Required(ErrorMessage = "Vehicle Number is required!")]
        public string VehicleNumber {  get; set; }
        public IEnumerable<Invoice>? Invoices { get; set; }
    }
}
