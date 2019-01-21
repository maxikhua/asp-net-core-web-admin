using System;
using Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace crm_web_admin.Controllers
{
    /// <summary>
    /// The user's controller. 
    /// </summary>
    [Route("api/user")]
    [ApiController]
    public class UserController
    {
        /// <summary>
        /// The user's service.
        /// </summary>
        private readonly IUserService _userService;

        /// <summary>
        /// The controller's constructor.
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Create specific user.
        /// </summary>
        /// <param name="thatUserDto">Specified user.</param>
        [HttpPost]
        public void Create(UserDto thatUserDto)
        {
            _userService.Create(thatUserDto);
        }

        /// <summary>
        /// Update specific user.
        /// </summary>
        /// <param name="thatUserDto">Specified user.</param>
        [HttpPut]
        public void Update(UserDto thatUserDto)
        {
            _userService.Update(thatUserDto);
        }

        /// <summary>
        /// Delete specific user.
        /// </summary>
        /// <param name="thatUserDto">Specified user.</param>
        [HttpDelete("{id}")]
        public void Delete(UserDto thatUserDto)
        {
            _userService.Delete(thatUserDto);
        }

        /// <summary>
        /// Get specific user.
        /// </summary>
        /// <param name="thatUserId">Specified user.</param>
        [HttpGet("{id}")]
        public void GetById(Guid thatUserId)
        {
            _userService.GetById(thatUserId);
        }

        /// <summary>
        /// Get all users.
        /// </summary>
        [HttpGet]
        public void GetAll()
        {
            _userService.GetAll();
        }
    }
}