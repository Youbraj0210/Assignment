using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp_API.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [Required(ErrorMessage = "Menu Name is Required!")]
        public string MenuName { get; set; }
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
    }
}
