using System;
using Models;
using Repositories.Configurations;
using Repositories.Contracts;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MongoContext _mongoContext;
        public bool Create(User thatUser)
        {
            throw new NotImplementedException();
        }

        public bool Update(User thatUser)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User thatUser)
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid thatId)
        {
            throw new NotImplementedException();
        }

        public User[] GetAll()
        {
            throw new NotImplementedException();
        }
    }
}