using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Repositories;

namespace FoodDeliveryApp_API.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repository;
        public InvoiceService(IInvoiceRepository repository)
        {
            _repository = repository;
        }
        public Invoice Add(Invoice invoice)
        {
            return _repository.Add(invoice);
        }
        public Invoice Update(Invoice invoice)
        {
            return _repository.Update(invoice);
        }
        public void Delete(Invoice invoice)
        {
            _repository.Delete(invoice);
        }
        public Invoice? GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<Invoice> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
