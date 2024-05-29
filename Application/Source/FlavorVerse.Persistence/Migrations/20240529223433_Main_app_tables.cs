using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Main_app_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cuisines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DietaryInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlutenFree = table.Column<bool>(type: "bit", nullable: false),
                    DairyFree = table.Column<bool>(type: "bit", nullable: false),
                    Vegetarian = table.Column<bool>(type: "bit", nullable: false),
                    Vegan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietaryInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutritions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: true),
                    Protein = table.Column<int>(type: "int", nullable: true),
                    Carbohydrates = table.Column<int>(type: "int", nullable: true),
                    Fat = table.Column<int>(type: "int", nullable: true),
                    Fiber = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titile = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CookingTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Servings = table.Column<int>(type: "int", nullable: false),
                    DifficultyId = table.Column<int>(type: "int", nullable: false),
                    DietaryInfoId = table.Column<int>(type: "int", nullable: false),
                    NutritionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Featured = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Instructions = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    MealTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_DietaryInfos_DietaryInfoId",
                        column: x => x.DietaryInfoId,
                        principalTable: "DietaryInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_DifficultyCookings_lu_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "DifficultyCookings_lu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_MealTypes_lu_MealTypeId",
                        column: x => x.MealTypeId,
                        principalTable: "MealTypes_lu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Nutritions_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "Nutritions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingValue = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCategories", x => new { x.RecipeId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_RecipeCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeCategories_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeCuisines",
                columns: table => new
                {
                    CuisineId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCuisines", x => new { x.RecipeId, x.CuisineId });
                    table.ForeignKey(
                        name: "FK_RecipeCuisines_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeCuisines_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "Main Courses", null },
                    { 2, "Appetizers", null },
                    { 3, "Salads", null },
                    { 4, "Desserts", null }
                });

            migrationBuilder.InsertData(
                table: "Cuisines",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Famous for pasta, pizza, and rich sauces.", "https://flagsapi.com/IT/flat/64.png", "Italian" },
                    { 2, "Known for noodles, dumplings, and diverse flavors.", "https://flagsapi.com/CN/flat/64.png", "Chinese" },
                    { 3, "Popular for tacos, burritos, and spicy dishes.", "https://flagsapi.com/MX/flat/64.png", "Mexican" },
                    { 4, "Renowned for sushi, ramen, and tempura.", "https://flagsapi.com/JP/flat/64.png", "Japanese" },
                    { 5, "Known for curries, spices, and diverse vegetarian dishes.", "https://flagsapi.com/IN/flat/64.png", "Indian" },
                    { 6, "Famous for pastries, wine, and sophisticated flavors.", "https://flagsapi.com/FR/flat/64.png", "French" },
                    { 7, "Known for its spicy curries and vibrant flavors.", "https://flagsapi.com/TH/flat/64.png", "Thai" },
                    { 8, "Popular for tapas, paella, and rich traditions.", "https://flagsapi.com/ES/flat/64.png", "Spanish" },
                    { 9, "Famous for gyros, olives, and feta cheese.", "https://flagsapi.com/GR/flat/64.png", "Greek" },
                    { 10, "Known for meze, kebabs, and fresh salads.", "https://flagsapi.com/LB/flat/64.png", "Lebanese" },
                    { 11, "Famous for kebabs, baklava, and strong coffee.", "https://flagsapi.com/TR/flat/64.png", "Turkish" },
                    { 12, "Popular for kimchi, BBQ, and vibrant dishes.", "https://flagsapi.com/KR/flat/64.png", "Korean" },
                    { 13, "Known for churrasco, feijoada, and tropical flavors.", "https://flagsapi.com/BR/flat/64.png", "Brazilian" },
                    { 14, "Famous for tagines, couscous, and rich spices.", "https://flagsapi.com/MA/flat/64.png", "Moroccan" },
                    { 15, "Known for pho, fresh herbs, and light dishes.", "https://flagsapi.com/VN/flat/64.png", "Vietnamese" },
                    { 16, "Popular for injera, stews, and communal eating.", "https://flagsapi.com/ET/flat/64.png", "Ethiopian" }
                });

            migrationBuilder.InsertData(
                table: "DietaryInfos",
                columns: new[] { "Id", "DairyFree", "GlutenFree", "Vegan", "Vegetarian" },
                values: new object[,]
                {
                    { 1, false, false, false, false },
                    { 2, false, false, true, false },
                    { 3, false, false, false, true },
                    { 4, false, false, true, true },
                    { 5, true, false, false, false },
                    { 6, true, false, true, false },
                    { 7, true, false, false, true },
                    { 8, true, false, true, true },
                    { 9, false, true, false, false },
                    { 10, false, true, true, false },
                    { 11, false, true, false, true },
                    { 12, false, true, true, true },
                    { 13, true, true, false, false },
                    { 14, true, true, true, false },
                    { 15, true, true, false, true },
                    { 16, true, true, true, true }
                });

            migrationBuilder.InsertData(
                table: "EntityTypes_lu",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Nutrition" },
                    { 3, "Rating" },
                    { 4, "Recipe" },
                    { 5, "Cuisine" },
                    { 6, "Ingredient" },
                    { 7, "Category" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Flour" },
                    { 2, "Sugar" },
                    { 3, "Salt" },
                    { 4, "Pepper" },
                    { 5, "Olive Oil" },
                    { 6, "Butter" },
                    { 7, "Garlic" },
                    { 8, "Onion" },
                    { 9, "Tomato" },
                    { 10, "Lemon Juice" },
                    { 11, "Chicken Breast" },
                    { 12, "Beef Steak" },
                    { 13, "Salmon Fillet" },
                    { 14, "Shrimp" },
                    { 15, "Eggs" },
                    { 16, "Milk" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 34, 33, 571, DateTimeKind.Utc).AddTicks(5341), "$2a$11$NKxXBpu0i9OFP5bAasS4ReP/d3F/UxDvA..frIy.AYvIyYTNG9QRC" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 5, "Seafood", 1 },
                    { 6, "Pasta", 1 },
                    { 7, "Soup", 2 },
                    { 8, "Dips", 2 },
                    { 9, "Greek Salad", 3 },
                    { 10, "Fruit Salad", 3 },
                    { 11, "Cakes", 4 },
                    { 12, "Cookies", 4 },
                    { 13, "Grilled", 1 },
                    { 14, "Stir Fry", 1 },
                    { 15, "Sandwiches", 1 },
                    { 16, "Stews", 1 },
                    { 17, "Burgers", 1 },
                    { 18, "Barbecue", 1 },
                    { 19, "Pizza", 1 },
                    { 20, "Wraps", 1 },
                    { 21, "Finger Foods", 2 },
                    { 22, "Spring Rolls", 2 },
                    { 23, "Mixed Greens", 3 },
                    { 24, "Coleslaw", 3 },
                    { 25, "Mousse", 4 },
                    { 26, "Pies", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuisines_Name",
                table: "Cuisines",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_Name",
                table: "Ingredients",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_RecipeId",
                table: "Ratings",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeCategories_CategoryId",
                table: "RecipeCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeCuisines_CuisineId",
                table: "RecipeCuisines",
                column: "CuisineId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DietaryInfoId",
                table: "Recipes",
                column: "DietaryInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DifficultyId",
                table: "Recipes",
                column: "DifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_MealTypeId",
                table: "Recipes",
                column: "MealTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_NutritionId",
                table: "Recipes",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "RecipeCategories");

            migrationBuilder.DropTable(
                name: "RecipeCuisines");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cuisines");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "DietaryInfos");

            migrationBuilder.DropTable(
                name: "Nutritions");

            migrationBuilder.DeleteData(
                table: "EntityTypes_lu",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EntityTypes_lu",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EntityTypes_lu",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EntityTypes_lu",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EntityTypes_lu",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EntityTypes_lu",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 54, 11, 258, DateTimeKind.Utc).AddTicks(5541), "$2a$11$oAPhpRAyBlYamMeHQ75C/uAMesuiB0bP0ttaNditkQyoQJLVjTdg2" });
        }
    }
}
