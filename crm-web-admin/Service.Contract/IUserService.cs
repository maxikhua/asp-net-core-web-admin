using System;
using Dtos;

namespace Services.Contracts
{
    public interface IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        bool Create(UserDto thatUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        bool Update(UserDto thatUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        bool Delete(UserDto thatUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatId"></param>
        /// <returns></returns>
        UserDto GetById(Guid thatId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UserDto[] GetAll();
    }
}