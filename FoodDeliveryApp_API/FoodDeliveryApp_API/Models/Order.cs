using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp_API.Models
{
    public class Order
    {
        [Key]
        public int OrderId {  get; set; }
        [Required(ErrorMessage = "Oreder date is Required!")]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate {  get; set; } = DateTime.Now;
        public List<OrderItem> Items { get; set; } = new();
        public double OrderTotalPrice {  get; set; }
        public double discount {  get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId {  get; set; }
        public Customer? Customer { get; set; }

    }
}
