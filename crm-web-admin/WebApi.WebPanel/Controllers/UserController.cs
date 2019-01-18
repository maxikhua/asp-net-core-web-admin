using System;
using Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace crm_web_admin.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IUserService _userService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUserDto"></param>
        [HttpPost]
        void Create(UserDto thatUserDto)
        {
            _userService.Create(thatUserDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUserDto"></param>
        [HttpPut]
        void Update(UserDto thatUserDto)
        {
            _userService.Update(thatUserDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUserDto"></param>
        [HttpDelete]
        void Delete(UserDto thatUserDto)
        {
            _userService.Delete(thatUserDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUserId"></param>
        [HttpGet]
        void GetById(Guid thatUserId)
        {
            _userService.GetById(thatUserId);
        }

        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        void GetAll()
        {
            _userService.GetAll();
        }
    }
}