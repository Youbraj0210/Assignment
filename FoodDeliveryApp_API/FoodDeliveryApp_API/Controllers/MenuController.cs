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
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _service;
        private readonly IMenuItemService _menuItemService;
        public MenuController(IMenuService service, IMenuItemService menuItemService)
        {
            _service = service;
            _menuItemService = menuItemService;
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]

        public IActionResult GetAllMenu()
        {
            var menus = _service.GetAll();
            if (menus == null)
                return NotFound();
            return Ok(menus);
        }

        [HttpPost]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]
        public IActionResult CreateMenu(MenuDTO menudto)
        {
            if (ModelState.IsValid)
            {
                Menu menu = new Menu()
                {
                    MenuName = menudto.MenuName,
                    Items = _service.GetMenuItemsById(menudto.MenuItemID)
                };
                _service.Add(menu);
                return Ok(menu);
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]

        public IActionResult GetMenuById(int id)
        {
            Menu menu = _service.GetById(id);
            if(menu == null)
                return NotFound();
            return Ok(menu);
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult UpdateMenu(int id, Menu menu)
        {
            Menu? existing = _service.GetById(id);
            if (existing == null)
                return NotFound();
            if (existing.MenuId.Equals(menu.MenuId) && ModelState.IsValid)
            {
               Menu UpdateMenu = _service.Update(menu);
                return Ok(UpdateMenu);
            }
            return BadRequest(menu);
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]

        public IActionResult DeleteMenu(int id)
        {
            Menu? existing = _service.GetById(id);
            if (existing == null)
                return NotFound();
            _service.Delete(existing);
            return Ok();
        }

        [HttpPut]
        [Route("{id}/addItem")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]
        public IActionResult AddItemToMenu(int id, int MenuItemId)
        {
            Menu? menu = _service.GetById(id);
            if(menu == null) return NotFound();
            MenuItem? menuItem = _menuItemService.GetById(MenuItemId);
            if (menuItem == null) return NotFound();
            menu.Items.Add(menuItem);
            Menu updateMenu = _service.Update(menu);
            return Ok(updateMenu);

        }
        [HttpPut]
        [Route("{id}/RemoveItem")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]
        public IActionResult RemoveMenuItem(int id, int MenuItemId)
        {
            Menu? menu = _service.GetById(id);
            if(menu == null) return NotFound();
            MenuItem? menuItem = _menuItemService.GetById(MenuItemId);
            if (menuItem == null) return NotFound();
            if (menu.Items.Contains(menuItem))
            {
                menu.Items.Remove(menuItem);
            }
            Menu updateMenu = _service.Update(menu);
            return Ok(updateMenu);

        }

    }
}
