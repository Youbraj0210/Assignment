using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodDeliveryApp_API.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemId {  get; set; }
        [Required(ErrorMessage = "Item Name is Required!")]
        public string MenuItemName {  get; set; }
        public string? MenuItemDescription {  get; set; }
        [Required(ErrorMessage = "Item Price is Required!")]
        [DataType(DataType.Currency)]
        public double MenuItemPrice { get; set; }
        [Required(ErrorMessage = "IsAvailable is required!")]
        public bool IsAvailable {  get; set; }
        [ForeignKey("Cuisine")]
        public int? CuisineId {  get; set; }
        public virtual Cuisine? Cuisine { get; set; }   
        public IEnumerable<Menu>? Menus { get; set; }
        [JsonIgnore]
        public IEnumerable<OrderItem>? OrderItems {  get; set; }
    }
}
