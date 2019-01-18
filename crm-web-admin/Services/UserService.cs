using System;
using Dtos;
using Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userRepository"></param>
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Create(UserDto thatUser)
        {
            return _userRepository.Create(new User()) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Update(UserDto thatUser)
        {
            return _userRepository.Update(new User()) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Delete(UserDto thatUser)
        {
            return _userRepository.Delete(new User()) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public UserDto GetById(Guid thatId)
        {
//            return _userRepository.GetById();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public UserDto[] GetAll()
        {
//            return _userRepository.GetAll();
        }
    }
}