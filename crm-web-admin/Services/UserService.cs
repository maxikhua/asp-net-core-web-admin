using System;
using AutoMapper;
using Dtos;
using Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public bool Create(UserDto thatUser)
        {
            return _userRepository.Create(new User());
        }

        public bool Update(UserDto thatUser)
        {
            return _userRepository.Update(new User());
        }

        public bool Delete(UserDto thatUser)
        {
            return _userRepository.Delete(new User());
        }

        public UserDto GetById(Guid thatId)
        {
            return _mapper.Map<UserDto>(_userRepository.GetById(thatId));
        }

        public UserDto[] GetAll()
        {
            return null;
        }
    }
}