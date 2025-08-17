using FoodDeliveryApp_API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp_API.DTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public List<int> Items { get; set; } = new();
        public int CustomerId { get; set; }
    }
}
