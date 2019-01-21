using System;
using Dtos;

namespace Services.Contracts
{
    public interface IUserService
    {
        bool Create(UserDto thatUser);

        bool Update(UserDto thatUser);

        bool Delete(UserDto thatUser);

        UserDto GetById(Guid thatId);

        UserDto[] GetAll();
    }
}