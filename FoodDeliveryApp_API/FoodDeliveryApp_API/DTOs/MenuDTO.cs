using FoodDeliveryApp_API.Models;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp_API.DTOs
{
    public class MenuDTO
    {
        public string MenuName { get; set; }
        public List<int>? MenuItemID { get; set; }
    }
}
