using FoodDeliveryApp_API.Data;
using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly FoodAppDBContext _dbContext;
        public InvoiceRepository(FoodAppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Invoice Add(Invoice invoice)
        {
            _dbContext.Invoices.Add(invoice);
            _dbContext.SaveChanges();
            return invoice;
        }
        public Invoice Update(Invoice invoice)
        {
            _dbContext.Entry(invoice).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
            return invoice;
        }
        public void Delete(Invoice invoice)
        {
            _dbContext.Invoices.Remove(invoice);
            _dbContext.SaveChanges();
        }
        public Invoice? GetById(int id)
        {
            return _dbContext.Invoices.Include(i=>i.Order).ThenInclude(o => o.Items)
                .ThenInclude(oi => oi.MenuItem).Include(i=>i.DeliveryPartner).FirstOrDefault(m => m.InvoiceId.Equals(id));
        }
        public IEnumerable<Invoice> GetAll()
        {
            return _dbContext.Invoices.ToList();
        }
    }
}
