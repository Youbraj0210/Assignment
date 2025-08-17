using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp_API.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId {  get; set; }
        [Required(ErrorMessage = "Unit price is required")]
        [DataType(DataType.Currency)]
        public double unitPrice {  get; set; }
        [Required(ErrorMessage = "Quantiy is Required!")]
        [Range(1,10,ErrorMessage ="Min order 1 and max 10")]
        public int Quantity {  get; set; }
        [ForeignKey("MenuItem")]
        public int? MenuItemId { get; set; }
        public MenuItem? MenuItem { get; set; }
        public virtual IEnumerable<Order>? Orders { get; set; }

    }
}
