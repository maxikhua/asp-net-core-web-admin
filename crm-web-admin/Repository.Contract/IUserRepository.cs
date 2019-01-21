using System;
using Models;

namespace Repositories.Contracts
{
    public interface IUserRepository
    {
        bool Create(User thatUser);


        bool Update(User thatUser);


        bool Delete(User thatUser);

        User GetById(Guid thatId);

        User[] GetAll();
    }
}