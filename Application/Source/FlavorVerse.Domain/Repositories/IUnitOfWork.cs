namespace FlavorVerse.Domain.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ISignInLogRepository SignInLogRepository { get; }
        IAuditRepository AuditRepository { get; }
        IErrorLogRepository ErrorLogRepository { get; }
        IRoleRepository RoleRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IRecipeRepository RecipeRepository { get; }
        ICuisineRepository CuisineRepository { get; }
        IIngredientRepoistory IngredientRepoistory { get; }
        IDietaryInfoRepository DietaryInfoRepository { get; }
        IMealTypeRepository MealTypeRepository { get; }
        IDifficultyCookingRepository DifficultyCookingRepository { get; }
        IRatingRepository RatingRepository { get; }
        INutritionRepository NutritionRepository { get; }

        Task<bool> Complete();

        bool HasChanges();
    }
}