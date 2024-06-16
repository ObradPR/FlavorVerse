using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Extensions;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FlavorVerse.Persistence.Repositories;

public class RecipeRepository : BaseRepository, IRecipeRepository
{
    public RecipeRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Recipe?> GetRecipeByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Recipes
            .Include(x => x.RecipeCategories)
            .Include(x => x.RecipeIngredients)
            .Include(x => x.RecipeCuisines)
            .Include(x => x.DietaryInfo)
            .FirstOrDefaultAsync(x => x.Id == id && x.IsActive, cancellationToken);
    }

    public async Task<Recipe?> GetCategoriesForRecipeAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Recipes
            .Include(x => x.RecipeCategories)
            .ThenInclude(x => x.Category)
            .Where(x => x.Id.Equals(id))
            .Select(x => new Recipe
            {
                Id = x.Id,
                Title = x.Title,
                RecipeCategories = x.RecipeCategories
                    .Where(rc => rc.Category.IsActive)
                    .Select(rc => new RecipeCategory
                    {
                        RecipeId = rc.RecipeId,
                        CategoryId = rc.CategoryId,
                        Category = rc.Category
                    }).ToList()
            })
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<Recipe?> GetCuisinesForRecipeAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Recipes
            .Include(x => x.RecipeCuisines)
            .ThenInclude(x => x.Cuisine)
            .Where(x => x.Id.Equals(id))
            .Select(x => new Recipe
            {
                Id = x.Id,
                Title = x.Title,
                RecipeCuisines = x.RecipeCuisines
                    .Select(rc => new RecipeCuisine
                    {
                        RecipeId = rc.RecipeId,
                        CuisineId = rc.CuisineId,
                        Cuisine = rc.Cuisine,
                    }).ToList()
            })
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<Recipe?> GetIngredientsForRecipeAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Recipes
            .Include(x => x.RecipeIngredients)
            .ThenInclude(x => x.Ingredient)
            .Where(x => x.Id.Equals(id))
            .Select(x => new Recipe
            {
                Id = x.Id,
                Title = x.Title,
                RecipeIngredients = x.RecipeIngredients
                    .Select(ri => new RecipeIngredient
                    {
                        RecipeId = ri.RecipeId,
                        IngredientId = ri.IngredientId,
                        Ingredient = ri.Ingredient,
                        Quantity = ri.Quantity
                    }).ToList()
            })
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<PaginatedList<Recipe>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Recipes
            .Include(x => x.User)
            .Include(x => x.DifficultyCooking_Lu)
            .Include(x => x.DietaryInfo)
            .Include(x => x.MealType_Lu)
            .Include(x => x.Nutrition)
            .Include(x => x.Ratings)
            .ThenInclude(x => x.User)
            .Include(x => x.RecipeCuisines)
            .ThenInclude(x => x.Cuisine)
            .Include(x => x.RecipeIngredients)
            .ThenInclude(x => x.Ingredient)
            .Include(x => x.RecipeCategories)
            .ThenInclude(x => x.Category)
            .AsQueryable();

        if (!string.IsNullOrEmpty(queryParams.SearchTerm))
        {
            query = query.Where(x => x.Title.ToLower().Contains(queryParams.SearchTerm));
        }

        if (!string.IsNullOrEmpty(queryParams.FilterCriteria) && !string.IsNullOrEmpty(queryParams.FilterDirection))
        {
            query = queryParams.FilterDirection.ToLower().Equals("asc") ?
                query.OrderByDynamic(queryParams.FilterCriteria) :
                query.OrderByDescendingDynamic(queryParams.FilterCriteria);
        }

        var totalRecords = await query.CountAsync(cancellationToken);

        var recipes = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .Where(x => x.IsActive)
            .ToListAsync(cancellationToken);

        return new PaginatedList<Recipe>
        {
            Items = recipes,
            TotalCount = totalRecords,
        };
    }

    public async Task<Recipe?> GetRecipeDetailsByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Recipes
            .Include(x => x.User)
            .Include(x => x.DifficultyCooking_Lu)
            .Include(x => x.DietaryInfo)
            .Include(x => x.MealType_Lu)
            .Include(x => x.Nutrition)
            .Include(x => x.Ratings)
            .ThenInclude(x => x.User)
            .Include(x => x.RecipeCuisines)
            .ThenInclude(x => x.Cuisine)
            .Include(x => x.RecipeIngredients)
            .ThenInclude(x => x.Ingredient)
            .Include(x => x.RecipeCategories)
            .ThenInclude(x => x.Category)
            .Where(x => x.IsActive)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task AddAsync(Recipe recipe, Nutrition nutrition, RecipeCuisine recipeCuisine, RecipeCategory recipeCategory, CancellationToken cancellationToken = default)
    {
        List<object> entities = [recipe, nutrition, recipeCuisine, recipeCategory];

        await Context.AddRangeAsync(entities, cancellationToken);
    }

    public async Task<bool> RecipeExistByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Recipes.FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken) is not null;
    }

    public async Task AddRecipeIngredientsAsync(List<RecipeIngredient> newIngredients, CancellationToken cancellationToken = default)
    {
        await Context.RecipeIngredients.AddRangeAsync(newIngredients, cancellationToken);
    }

    public async Task AddRecipeCuisinesAsync(List<RecipeCuisine> newCuisines, CancellationToken cancellationToken = default)
    {
        await Context.RecipeCuisines.AddRangeAsync(newCuisines, cancellationToken);
    }

    public async Task AddRecipeCategoriesAsync(List<RecipeCategory> newCategories, CancellationToken cancellationToken = default)
    {
        await Context.RecipeCategories.AddRangeAsync(newCategories, cancellationToken);
    }

    public async Task<RecipeCategory?> GetRecipeCategoryByIdsAsync(Guid recipeId, int categoryId, CancellationToken cancellationToken)
    {
        return await Context.RecipeCategories.FirstOrDefaultAsync(x => x.RecipeId == recipeId && x.CategoryId == categoryId, cancellationToken);
    }

    public void DeleteRecipeCategory(RecipeCategory recipeCateogory)
    {
        Context.RecipeCategories.Remove(recipeCateogory);
    }

    public async Task<RecipeIngredient?> GetRecipeIngredientByIdsAsync(Guid recipeId, int ingredientId, CancellationToken cancellationToken)
    {
        return await Context.RecipeIngredients.FirstOrDefaultAsync(x => x.RecipeId == recipeId && x.IngredientId == ingredientId, cancellationToken);
    }

    public async Task<RecipeCuisine?> GetRecipeCuisineByIdsAsync(Guid recipeId, int cuisineId, CancellationToken cancellationToken)
    {
        return await Context.RecipeCuisines.FirstOrDefaultAsync(x => x.RecipeId == recipeId && x.CuisineId == cuisineId, cancellationToken);
    }

    public void DeleteRecipeCuisine(RecipeCuisine recipeCuisine)
    {
        Context.RecipeCuisines.Remove(recipeCuisine);
    }

    public async Task<Recipe?> GetRecipeByNutritionIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Recipes.FirstOrDefaultAsync(x => x.NutritionId.Equals(id), cancellationToken);
    }
}