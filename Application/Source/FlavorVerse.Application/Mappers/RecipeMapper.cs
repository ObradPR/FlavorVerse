using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Dtos.Recipe;
using FlavorVerse.Application.Dtos.User;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class RecipeMapper : BaseAutoMapperProfile
{
    public RecipeMapper()
    {
        CreateMap<Recipe, RecipeDto>()
            .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User))
            .ForMember(dest => dest.DifficultyCooking, opt => opt.MapFrom(src => src.DifficultyCooking_Lu))
            .ForMember(dest => dest.DietaryInfo, opt => opt.MapFrom(src => src.DietaryInfo))
            .ForMember(dest => dest.MealType, opt => opt.MapFrom(src => src.MealType_Lu))
            .ForMember(dest => dest.Nutrition, opt => opt.MapFrom(src => src.Nutrition))
            .ForMember(dest => dest.Ratings, opt => opt.MapFrom(src => src.Ratings.Where(x => x.IsActive).Select(x => new RatingDto
            {
                Id = x.Id,
                RatingValue = x.RatingValue,
                Comment = x.Comment,
                User = new RatingUserDto
                {
                    Id = x.User.Id,
                    DisplayName = x.User.DisplayName,
                }
            }).ToList()))
            .ForMember(dest => dest.Cuisines, opt => opt.MapFrom(src => src.RecipeCuisines.Where(x => x.Cuisine.IsActive).Select(x => new CuisineDto
            {
                Id = x.Cuisine.Id,
                Name = x.Cuisine.Name,
                Description = x.Cuisine.Description,
                Image = x.Cuisine.Image,
            }).ToList()))
            .ForMember(dest => dest.Ingredients, opt => opt.MapFrom(src => src.RecipeIngredients.Where(x => x.Ingredient.IsActive).Select(x => new IngredientDto
            {
                Id = x.Ingredient.Id,
                Name = x.Ingredient.Name,
                Quantity = x.Quantity,
            }).ToList()))
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.RecipeCategories.Where(x => x.Category.IsActive).Select(x => new CategoryDto
            {
                Id = x.Category.Id,
                Name = x.Category.Name,
                ParentId = x.Category.ParentId
            })));

        CreateMap<PaginatedList<Recipe>, PaginatedList<RecipeDto>>();
    }
}