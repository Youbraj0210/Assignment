using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp_API.Models
{
    public enum CuisineType
    {
        INDIAN,
        ITALIAN,
        CHINESE,
        JAPANESE,
        MEXICAN,
        SPANISH,
        KOREAN,
        SOUTHINDIAN,
        PUNJABI,
        GUJARATI,
        RAJASTHANI,
        BENGALI,
        MAHARASHTRIAN
    }
    public class Cuisine
    {
        [Key]
        public int CuisineId { get; set; }
        [Required(ErrorMessage = "Cuisine type is Required!")]
        public CuisineType CuisineType { get; set; }
        public virtual IEnumerable<MenuItem>? MenuItems { get; set; }

    }
}
