using FoodDeliveryApp_API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp_API.DTOs
{
    public class InvoiceDTO
    {
        public string PaymentMode { get; set; }
        public int OrderId { get; set; }
    }
}
