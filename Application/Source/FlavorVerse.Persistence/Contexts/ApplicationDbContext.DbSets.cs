using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Entities.Application_lu;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Contexts
{
    public partial class ApplicationDbContext
    {
        // Lu_Tables

        public virtual DbSet<Role_lu> Roles_lu { get; set; }
        public virtual DbSet<EntityType_lu> EntityTypes_lu { get; set; }
        public virtual DbSet<ActionType_lu> ActionTypes_lu { get; set; }
        public virtual DbSet<DifficultyCooking_lu> DifficultyCookings_lu { get; set; }
        public virtual DbSet<MealType_lu> MealTypes_lu { get; set; }

        // Tables

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<SignInLog> SignInLogs { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cuisine> Cuisines { get; set; }
        public virtual DbSet<DietaryInfo> DietaryInfos { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Nutrition> Nutritions { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipeCategory> RecipeCategories { get; set; }
        public virtual DbSet<RecipeCuisine> RecipeCuisines { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    }
}