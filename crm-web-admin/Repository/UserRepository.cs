using System;
using Models;
using Repositories.Contracts;

namespace Repositories
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        /// <exception cref="T:System.NotImplementedException"></exception>
        public bool Create(User thatUser)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        /// <exception cref="T:System.NotImplementedException"></exception>
        public bool Update(User thatUser)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="thatUser"></param>
        /// <returns></returns>
        /// <exception cref="T:System.NotImplementedException"></exception>
        public bool Delete(User thatUser)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="thatId"></param>
        /// <returns></returns>
        /// <exception cref="T:System.NotImplementedException"></exception>
        public User GetById(Guid thatId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// <exception cref="T:System.NotImplementedException"></exception>
        public User[] GetAll()
        {
            throw new NotImplementedException();
        }
    }
}