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
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("SignUp")]
        public IActionResult PostSignup(UserDTO usr)
        {
            if(ModelState.IsValid)
            {
                User user = new User
                {
                    UserFullName = usr.UserFullName,
                    UserName = usr.UserName,
                    UserEmail = usr.UserEmail,
                    UserPhone = usr.UserPhone,
                    Password = usr.Password,
                    RoleId = usr.RoleId
                };
                User addedUser = _service.Add(user);
                return Ok(addedUser);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("/api/Customer/SignUp")]
        public IActionResult CustomerSignUp(CustomerDTO usr)
        {
            if(ModelState.IsValid)
            {
                Customer user = new Customer
                {
                    UserFullName = usr.UserFullName,
                    UserName = usr.UserName,
                    UserEmail = usr.UserEmail,
                    UserPhone = usr.UserPhone,
                    Password = usr.Password,
                    RoleId = usr.RoleId,
                    city = usr.city,
                    State = usr.State,
                    Pincode = usr.Pincode,
                    Address = usr.Address
                };
                User addedUser = _service.Add(user);
                return Ok(addedUser);
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("/api/DeliveryPartner/SignUp")]
        public IActionResult DeliveryPartnerSignUp(DeliveryPartnerDTO usr)
        {
            if(ModelState.IsValid)
            {
                DeliveryPartner user = new DeliveryPartner
                {
                    UserFullName = usr.UserFullName,
                    UserName = usr.UserName,
                    UserEmail = usr.UserEmail,
                    UserPhone = usr.UserPhone,
                    Password = usr.Password,
                    RoleId = usr.RoleId,
                    VehicleNumber = usr.VehicleNumber
                };
                User addedUser = _service.Add(user);
                return Ok(addedUser);
            }
            return BadRequest();
        }
        [HttpGet]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]
        public IActionResult GetAllUsers()
        {
            var users = _service.GetAll();
            if (users != null)
            {
                return Ok(users);
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("/api/Customers")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]
        public IActionResult GetAllCustomers()
        {
            var users = _service.GetAllCustomers();
            if (users != null)
            {
                return Ok(users);
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("/api/DeliverPartners")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]
        public IActionResult GetAllDeliveryPartners()
        {
            var users = _service.GetAllDeliveryPartners();
            if (users != null)
            {
                return Ok(users);
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("/api/Customer/{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)}")]
        public IActionResult UpdateUser(int id,Customer user)
        {
            if(ModelState.IsValid && user.UserId==id)
            {
                User? existing = _service.GetById(id);
                if(existing != null)
                {
                    User UpdatedUser = _service.Update(user);
                    return Ok(UpdatedUser);
                }
            }
            return BadRequest();
        }
        [HttpPut]
        [Route("/api/DeliveryPartner/{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.DELIVERY_PARTNER)}")]
        public IActionResult UpdateDeliveryPartner(int id,DeliveryPartner user)
        {
            if(ModelState.IsValid && user.UserId==id)
            {
                User? existing = _service.GetById(id);
                if(existing != null)
                {
                    User UpdatedUser = _service.Update(user);
                    return Ok(UpdatedUser);
                }
            }
            return BadRequest();
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)}")]
        public IActionResult UpdateUser(int id,User user)
        {
            if (ModelState.IsValid && user.UserId == id)
            {
                User? existing = _service.GetById(id);
                if (existing != null)
                {
                    User UpdatedUser = _service.Update(user);
                    return Ok(UpdatedUser);
                }
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)},{nameof(Role.DELIVERY_PARTNER)}")]
        public IActionResult GetUserById(int id)
        {
            User? user = _service.GetById(id);
            if(user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(Role.ADMIN)},{nameof(Role.CUSTOMER)},{nameof(Role.DELIVERY_PARTNER)}")]
        public IActionResult DeleteUser(int id)
        {
            User? user = _service.GetById(id);
            if(user != null )
            {
                _service.Delete(user);
                return Ok();
            }
            return BadRequest();
        }
    }
}
