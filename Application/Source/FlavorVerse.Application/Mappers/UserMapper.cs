using FlavorVerse.Application.Dtos.Auth;
using FlavorVerse.Application.Dtos.User;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class UserMapper : BaseAutoMapperProfile
{
    public UserMapper()
    {
        CreateMap<User, AuthResponseDto>();
        CreateMap<UserProfileDto, User>();
        CreateMap<User, UserProfileDto>();
        CreateMap<PaginatedList<User>, PaginatedList<UserProfileDto>>();
    }
}