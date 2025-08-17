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
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _service;
        public MenuItemController(IMenuItemService service)
        {
            _service = service;
        }
        [HttpGet]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult GetAllMenuItems()
        {
            var menuItems = _service.GetAll();
            if (menuItems != null)
            {
                return Ok(menuItems);
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]
        public IActionResult GetMenuItemById(int id)
        {
            MenuItem? item = _service.GetById(id);
            if (item != null)
            {
                return Ok(item);
            }
            return NotFound();
        }
        [HttpPost]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult CreateMenuItem(MenuItemDTO mi)
        {
            if (ModelState.IsValid)
            {
                MenuItem menuItem = new MenuItem
                {
                    MenuItemName = mi.MenuItemName,
                    MenuItemDescription = mi.MenuItemDescription,
                    MenuItemPrice = mi.MenuItemPrice,
                    IsAvailable = mi.IsAvailable,
                    CuisineId = mi.CuisineId
                };
                MenuItem addedItem = _service.Add(menuItem);
                return Ok(addedItem);
            }
            return BadRequest();
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult UpdateMenuItem(int id, MenuItem menuItem)
        {
            if(ModelState.IsValid && menuItem.MenuItemId == id)
            {
                MenuItem? item = _service.GetById(id);
                if(item != null)
                {
                    MenuItem updatedMenuItem = _service.Update(menuItem);
                    return Ok(updatedMenuItem);
                }
                return NotFound();
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult DeleteMenuItem(int id)
        {
            MenuItem? menuItem = _service.GetById(id);
            if(menuItem != null)
            {
                _service.Delete(menuItem);
                return Ok();
            }
            return BadRequest();
        }
        [HttpPatch]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult SoftDeleteMenuitem(int id, [FromBody] bool isAvailable)
        {
            MenuItem? menuItem = _service.GetById(id);
            if(menuItem != null)
            {
                menuItem.IsAvailable = isAvailable;
                _service.Update(menuItem);
                return Ok();
            }
            return BadRequest();
        }
    }
}
