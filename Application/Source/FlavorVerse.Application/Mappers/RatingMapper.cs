using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class RatingMapper : BaseAutoMapperProfile
{
    public RatingMapper()
    {
        CreateMap<Rating, AdminRatingDto>()
            .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));

        CreateMap<PaginatedList<Rating>, PaginatedList<AdminRatingDto>>();

        CreateMap<Rating, UserRatingDto>()
            .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));

        CreateMap<PaginatedList<Rating>, PaginatedList<UserRatingDto>>();
    }
}