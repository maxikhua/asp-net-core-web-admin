using AutoMapper;
using Dtos;
using Models;

namespace Services.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User[], UserDto[]>().ReverseMap();
        }
    }
}