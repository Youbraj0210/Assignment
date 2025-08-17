using Azure.Core;
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
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService _service;
        public OrderItemController(IOrderItemService orderItemService)
        {
            _service = orderItemService;
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult GetAllOrderItems()
        {
            var orderItems = _service.GetAll();
            if (orderItems == null)
                return NotFound();
            return Ok(orderItems);
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]

        public IActionResult GetOrderItemsById(int id)
        {
            OrderItem? existing = _service.GetById(id);
            if (existing == null)
                return NotFound();
            return Ok(existing);
        }

        [HttpPost]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]
        public IActionResult CreateOrderItem(OrderItemDTO oi)
        {
            if(ModelState.IsValid)
            {
                OrderItem item = new OrderItem
                {
                    MenuItemId = oi.MenuItemId,
                    Quantity = oi.Quantity
                };
                OrderItem addedItem = _service.Add(item);
                return Ok(addedItem);
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]
        public IActionResult UpdateOrderItem(int id, OrderItem item)
        {
            var existing = _service.GetById(id);
            if(existing == null)
                return NotFound();
            if(ModelState.IsValid && item.OrderItemId.Equals(id))
            {
                OrderItem UpdatedOrderItem = _service.Update(item);
                return Ok(UpdatedOrderItem);
            }
            return BadRequest();
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]
        public IActionResult DeleteOrderItem(int id)
        {
            var existing = _service.GetById(id);
            if (existing == null)
                return NotFound();
            _service.Delete(existing);
            return Ok();
        }

    }
}
