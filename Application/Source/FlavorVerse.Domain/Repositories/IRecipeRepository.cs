using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using System.Threading;

namespace FlavorVerse.Domain.Repositories;

public interface IRecipeRepository
{
    Task<Recipe?> GetRecipeByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Recipe?> GetCategoriesForRecipeAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Recipe?> GetCuisinesForRecipeAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Recipe?> GetIngredientsForRecipeAsync(Guid id, CancellationToken cancellationToken = default);

    Task<PaginatedList<Recipe>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default);

    Task<Recipe?> GetRecipeDetailsByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task AddAsync(Recipe recipe, Nutrition nutrition, RecipeCuisine recipeCuisine, RecipeCategory recipeCategory, CancellationToken cancellationToken = default);

    Task<bool> RecipeExistByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task AddRecipeIngredientsAsync(List<RecipeIngredient> newIngredients, CancellationToken cancellationToken = default);

    Task AddRecipeCuisinesAsync(List<RecipeCuisine> newCuisines, CancellationToken cancellationToken = default);

    Task AddRecipeCategoriesAsync(List<RecipeCategory> newCategories, CancellationToken cancellationToken = default);

    Task<RecipeCategory?> GetRecipeCategoryByIdsAsync(Guid recipeId, int categoryId, CancellationToken cancellationToken);

    void DeleteRecipeCategory(RecipeCategory recipeCateogory);

    Task<RecipeIngredient?> GetRecipeIngredientByIdsAsync(Guid recipeId, int ingredientId, CancellationToken cancellationToken);

    Task<RecipeCuisine?> GetRecipeCuisineByIdsAsync(Guid recipeId, int cuisineId, CancellationToken cancellationToken);

    void DeleteRecipeCuisine(RecipeCuisine recipeCuisine);

    Task<Recipe?> GetRecipeByNutritionIdAsync(Guid id, CancellationToken cancellationToken = default);
}