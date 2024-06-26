﻿using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Dtos.DifficultyCooking;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Dtos.Nutrition;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Dtos.User;

namespace FlavorVerse.Application.Dtos.Recipe;

public class RecipeDto : BaseDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CookingTime { get; set; } = string.Empty;
    public int Servings { get; set; }
    public bool Featured { get; set; }
    public string Instructions { get; set; } = string.Empty;
    public UserDto User { get; set; }
    public DifficultyCookingDto DifficultyCooking { get; set; }
    public DietaryInfoDto DietaryInfo { get; set; }
    public MealTypeDto MealType { get; set; }
    public NutritionDto Nutrition { get; set; }
    public List<RatingDto> Ratings { get; set; }
    public List<CuisineDto> Cuisines { get; set; }
    public List<IngredientDto> Ingredients { get; set; }
    public List<CategoryDto> Categories { get; set; }
}