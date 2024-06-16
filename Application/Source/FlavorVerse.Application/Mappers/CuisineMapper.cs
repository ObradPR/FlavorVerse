using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class CuisineMapper : BaseAutoMapperProfile
{
    public CuisineMapper()
    {
        CreateMap<Cuisine, CuisineDto>();

        CreateMap<PaginatedList<Cuisine>, PaginatedList<CuisineDto>>();

        CreateMap<Recipe, RecipeCuisinesDto>()
            .ForMember(dest => dest.RecipeId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.RecipeTitle, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Cuisines, opt => opt.MapFrom(src => src.RecipeCuisines.Select(x => new CuisineDto
            {
                Id = x.Cuisine.Id,
                Name = x.Cuisine.Name,
                Description = x.Cuisine.Description,
                Image = x.Cuisine.Image
            }).ToList()));
    }
}