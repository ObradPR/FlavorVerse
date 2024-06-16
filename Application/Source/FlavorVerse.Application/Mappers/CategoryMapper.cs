using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class CategoryMapper : BaseAutoMapperProfile
{
    public CategoryMapper()
    {
        CreateMap<Category, CategoryDto>();

        CreateMap<PaginatedList<Category>, PaginatedList<CategoryDto>>();

        CreateMap<Recipe, RecipeCategoriesDto>()
            .ForMember(dest => dest.RecipeId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.RecipeTitle, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.RecipeCategories.Select(x => new CategoryDto
            {
                Id = x.Category.Id,
                Name = x.Category.Name,
                ParentId = x.Category.ParentId
            }).ToList()));
    }
}