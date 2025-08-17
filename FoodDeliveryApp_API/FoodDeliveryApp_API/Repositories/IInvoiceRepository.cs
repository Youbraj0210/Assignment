using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public interface IInvoiceRepository
    {
        public Invoice Add(Invoice invoice);
        public Invoice Update(Invoice invoice);
        public void Delete(Invoice invoice);
        public Invoice? GetById(int id);
        public IEnumerable<Invoice> GetAll();
    }
}
