using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp_API.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId {  get; set; }
        [Required(ErrorMessage = "Payment Mode is Required!")]
        public string PaymentMode {  get; set; }
        [ForeignKey("Order")]
        public int? OrderId {  get; set; }
        public Order? Order { get; set; }
        [ForeignKey("DeliveryPartner")]
        public int? DeliveryPartnerId {  get; set; }
        public DeliveryPartner? DeliveryPartner { get; set; }

    }
}
