using FoodDeliveryApp_API.DTOs;
using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _service;
        private readonly IUserService _userService;
        public InvoiceController(IInvoiceService service, IUserService userService)
        {
            _service = service;
            _userService = userService;
        }

        [HttpGet]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult GetAllInvoices()
        {
            var invoices = _service.GetAll();
            if (invoices == null)
                return NotFound("no invoices to show");
            return Ok(invoices);
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult GetInvoiceById(int id)
        {
            Invoice invoice = _service.GetById(id);
            if (invoice == null)
                return NotFound("Invoice with this id doesnt exist!");
            return Ok(invoice);
        }
        [HttpPost]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult CreateInvoice(InvoiceDTO invc)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var deliveryPartner = _userService.GetAllDeliveryPartners();

            Random rnd = new Random();
            int index = rnd.Next(0, deliveryPartner.Count());

            Invoice invoice = new Invoice
            {
                PaymentMode = invc.PaymentMode,
                OrderId = invc.OrderId,
                DeliveryPartner = deliveryPartner.ElementAt(index)
            };

            Invoice AddedInvoice = _service.Add(invoice);
            return Ok(AddedInvoice);
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles= nameof(Role.ADMIN))]
        public IActionResult UpdateInvoice(int id, Invoice invoice)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (invoice.InvoiceId != id)
                return BadRequest("id doesnt match");

            Invoice updateInvoice = _service.Update(invoice);
            return Ok(updateInvoice);
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult DeleteInvoice(int id)
        {
            Invoice? invoice = _service.GetById(id);
            if (invoice == null)
                return NotFound("invoice doesnt exist!");
            _service.Delete(invoice);
            return Ok();
        }
    }
}
