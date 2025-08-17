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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }
        [HttpGet]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult GetAllOrders()
        {
            var orders = _service.GetAll();
            if (orders == null)
                return NotFound();
            return Ok(orders);
        }

        [HttpPost]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]
        public IActionResult CreateOrder(OrderDTO orderdto)
        {
            if (ModelState.IsValid)
            {
                var items = _service.GetOrderItemsById(orderdto.Items);
                double total = items.Sum(oi => oi.unitPrice);
                double discount = 0;
                if (total > 500)
                {
                    discount = 0.05 * total;
                    total -= discount;
                }
                Order order = new Order
                {
                    OrderDate = orderdto.OrderDate,
                    CustomerId = orderdto.CustomerId,
                    Items = items,
                    OrderTotalPrice = total,
                    discount = discount
                };
                _service.Add(order);
                return Ok(order);
            }
            return BadRequest(ModelState);
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]
        public IActionResult GetOrderByID(int id)
        {
            Order? order = _service.GetById(id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]
        public IActionResult UpdateOrder(int id, OrderDTO dto)
        {
            if (id != dto.OrderId)
                return BadRequest("ID mismatch");

            var existing = _service.GetById(id);
            if (existing == null)
                return NotFound();

            var items = _service.GetOrderItemsById(dto.Items);

            existing.OrderDate = dto.OrderDate;
            existing.CustomerId = dto.CustomerId;
            existing.Items ??= new List<OrderItem>();
            existing.Items.Clear();

            foreach (var item in items)
            {
                existing.Items.Add(item);
            }

            existing.OrderTotalPrice = existing.Items.Sum(i => i.unitPrice);
            if(existing.OrderTotalPrice > 500)
            {
                existing.discount = 0.05 * existing.OrderTotalPrice;
                existing.OrderTotalPrice -= existing.discount;
            }

            _service.Update(existing);
            return Ok(existing);
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]

        public IActionResult DeleteOrder(int id)
        {
            Order? existing = _service.GetById(id);
            if (existing == null)
                return NotFound();
            _service.Delete(existing);
            return Ok();
        }
    }
}
