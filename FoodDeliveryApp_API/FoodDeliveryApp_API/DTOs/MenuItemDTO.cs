using FoodDeliveryApp_API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodDeliveryApp_API.DTOs
{
    public class MenuItemDTO
    {
        [JsonIgnore]
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public string? MenuItemDescription { get; set; }
        [Required(ErrorMessage = "Item Price is Required!")]
        [DataType(DataType.Currency)]
        public double MenuItemPrice { get; set; }
        public bool IsAvailable { get; set; }
        public int CuisineId { get; set; }
    }
}
