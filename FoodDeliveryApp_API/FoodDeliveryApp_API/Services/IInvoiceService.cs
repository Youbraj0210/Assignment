using FoodDeliveryApp_API.Models;

namespace FoodDeliveryApp_API.Services
{
    public interface IInvoiceService
    {
        public Invoice Add(Invoice invoice);
        public Invoice Update(Invoice invoice);
        public void Delete(Invoice invoice);
        public Invoice? GetById(int id);
        public IEnumerable<Invoice> GetAll();
    }
}
