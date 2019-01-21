using System;
using Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace crm_web_admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        void Create(UserDto thatUserDto)
        {
            _userService.Create(thatUserDto);
        }

        [HttpPut]
        void Update(UserDto thatUserDto)
        {
            _userService.Update(thatUserDto);
        }

        [HttpDelete]
        void Delete(UserDto thatUserDto)
        {
            _userService.Delete(thatUserDto);
        }

        [HttpGet]
        void GetById(Guid thatUserId)
        {
            _userService.GetById(thatUserId);
        }

        [HttpGet]
        void GetAll()
        {
            _userService.GetAll();
        }
    }
}