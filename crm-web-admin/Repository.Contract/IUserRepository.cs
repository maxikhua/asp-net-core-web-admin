using System;
using Models;

namespace Repositories.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        bool Create(User thatUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        bool Update(User thatUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        bool Delete(User thatUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thatId"></param>
        /// <returns></returns>
        User GetById(Guid thatId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        User[] GetAll();
    }
}