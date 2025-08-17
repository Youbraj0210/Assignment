using FoodDeliveryApp_API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp_API.DTOs
{
    public class OrderItemDTO
    {
        [Range(1, 10, ErrorMessage = "Min order 1 and max 10")]
        public int Quantity { get; set; }
        public int MenuItemId { get; set; }
    }
}
