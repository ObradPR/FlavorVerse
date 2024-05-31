using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_recipe_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titile",
                table: "Recipes",
                newName: "Title");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 27, "Chicken Dishes", 1 },
                    { 28, "Tacos", 1 },
                    { 29, "Beef Dishes", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 17, "Spaghetti" },
                    { 18, "Parmesan Cheese" },
                    { 19, "Pancetta" },
                    { 20, "Black Pepper" },
                    { 21, "Cucumber" },
                    { 22, "Red Onion" },
                    { 23, "Feta Cheese" },
                    { 24, "Oregano" },
                    { 25, "Black Olives" },
                    { 26, "Romaine Lettuce" },
                    { 27, "Caesar Dressing" },
                    { 28, "Croutons" },
                    { 29, "Bell Peppers" },
                    { 30, "Broccoli" },
                    { 31, "Carrot" },
                    { 32, "Soy Sauce" },
                    { 33, "Taco Seasoning" },
                    { 34, "Tortillas" },
                    { 35, "Lettuce" },
                    { 36, "Cheddar Cheese" },
                    { 37, "Sour Cream" },
                    { 38, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CreatedAt", "DeletedAt", "DeletedBy", "Fat", "Fiber", "IsActive", "ModifiedAt", "ModifiedBy", "Protein" },
                values: new object[,]
                {
                    { new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"), 150, 10, new DateTime(2024, 5, 31, 16, 22, 35, 501, DateTimeKind.Utc).AddTicks(5597), null, null, 12, 3, true, null, null, 4 },
                    { new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"), 400, 45, new DateTime(2024, 5, 31, 16, 22, 35, 501, DateTimeKind.Utc).AddTicks(5587), null, null, 20, 2, true, null, null, 15 }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CreatedAt", "DeletedAt", "DeletedBy", "Fat", "Fiber", "ModifiedAt", "ModifiedBy", "Protein" },
                values: new object[,]
                {
                    { new Guid("c1b3e572-59a1-4e3e-8a5f-7f4a9b5e2c58"), 200, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 8, 6, null, null, 5 },
                    { new Guid("d4e4a728-8b91-4c8f-9e7d-c2f918c3b8b5"), 350, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 15, 3, null, null, 30 },
                    { new Guid("e7b2a0de-5f15-4e7f-89f3-2a8e0c3e07d6"), 250, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10, 4, null, null, 20 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 22, 35, 620, DateTimeKind.Utc).AddTicks(5513), "$2a$11$pNqdjoHO519QIRwNGHnMjOgUJLV.OnR.g6sc2uo54G4Zh7FXW9Dlm" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "FirstName", "LastName", "ModifiedAt", "ModifiedBy", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"), new DateTime(2024, 5, 31, 16, 22, 35, 859, DateTimeKind.Utc).AddTicks(4829), new DateOnly(1999, 3, 18), null, null, "nenad.obradovic221@gmail.com", "Nenad", "Obradović", null, null, "$2a$11$o9yzxPodULbYWHPoKvx5.OXxfYR3B3qow62ysFbEkniN8x419uCHi", "" },
                    { new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"), new DateTime(2024, 5, 31, 16, 22, 35, 743, DateTimeKind.Utc).AddTicks(8648), new DateOnly(1995, 12, 29), null, null, "vnemanjic@gmail.com", "Vukota", "Nemanjić", null, null, "$2a$11$dNbKJWNWQWSWGTgUsALAt.UiXRqelq1JfDCzV6CTTAc0FMTcyFfxi", "" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CookingTime", "CreatedAt", "DeletedAt", "DeletedBy", "Description", "DietaryInfoId", "DifficultyId", "Image", "Instructions", "IsActive", "MealTypeId", "ModifiedAt", "ModifiedBy", "NutritionId", "Servings", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "25 minutes", new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3406), null, null, "A quick and easy stir fry with a variety of vegetables in a savory sauce.", 11, 2, "https://example.com/images/vegetable-stir-fry.jpg", "1. Chop vegetables. 2. Stir fry in a hot pan. 3. Add sauce and cook until tender.", true, 2, null, null, new Guid("c1b3e572-59a1-4e3e-8a5f-7f4a9b5e2c58"), 3, "Vegetable Stir Fry", new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") },
                    { new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), "20 minutes", new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3379), null, null, "A classic Caesar salad with grilled chicken, romaine lettuce, croutons, and Caesar dressing.", 5, 1, "https://example.com/images/chicken-caesar-salad.jpg", "1. Grill chicken. 2. Chop lettuce. 3. Mix lettuce, croutons, and dressing. 4. Top with chicken.", true, 2, null, null, new Guid("d4e4a728-8b91-4c8f-9e7d-c2f918c3b8b5"), 2, "Chicken Caesar Salad", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), "30 minutes", new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3364), null, null, "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.", 5, 2, "https://example.com/images/spaghetti-carbonara.jpg", "1. Cook pasta. 2. Cook pancetta. 3. Mix eggs and cheese. 4. Combine all and season.", true, 3, null, null, new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"), 4, "Spaghetti Carbonara", new Guid("00000000-0000-0000-0000-000000000001") }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CookingTime", "CreatedAt", "DeletedAt", "DeletedBy", "Description", "DietaryInfoId", "DifficultyId", "Featured", "Image", "Instructions", "IsActive", "MealTypeId", "ModifiedAt", "ModifiedBy", "NutritionId", "Servings", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "15 minutes", new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3374), null, null, "A fresh and healthy salad made with tomatoes, cucumbers, onions, olives, and feta cheese.", 11, 1, true, "https://example.com/images/greek-salad.jpg", "1. Chop vegetables. 2. Mix in a bowl. 3. Add olives and feta cheese. 4. Drizzle with olive oil.", true, 1, null, null, new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"), 2, "Greek Salad", new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") },
                    { new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), "20 minutes", new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3415), null, null, "Tasty tacos filled with seasoned beef, lettuce, cheese, and salsa.", 1, 1, true, "https://example.com/images/beef-tacos.jpg", "1. Cook beef with seasoning. 2. Prepare taco shells. 3. Fill with beef and toppings.", true, 3, null, null, new Guid("e7b2a0de-5f15-4e7f-89f3-2a8e0c3e07d6"), 4, "Beef Tacos", new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "CategoryId", "RecipeId" },
                values: new object[,]
                {
                    { 1, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                    { 14, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                    { 1, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                    { 3, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                    { 27, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                    { 1, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") },
                    { 6, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") },
                    { 3, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                    { 9, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                    { 1, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                    { 28, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                    { 29, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") }
                });

            migrationBuilder.InsertData(
                table: "RecipeCuisines",
                columns: new[] { "CuisineId", "RecipeId" },
                values: new object[,]
                {
                    { 2, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                    { 1, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                    { 1, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") },
                    { 9, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                    { 3, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity" },
                values: new object[,]
                {
                    { 3, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "to taste" },
                    { 4, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "to taste" },
                    { 5, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "2 tbsp" },
                    { 7, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "2 cloves" },
                    { 8, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "1" },
                    { 29, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "2" },
                    { 30, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "1 head" },
                    { 31, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "2" },
                    { 32, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), "3 tbsp" },
                    { 11, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), "200g" },
                    { 18, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), "50g" },
                    { 26, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), "1 head" },
                    { 27, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), "100ml" },
                    { 28, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), "50g" },
                    { 15, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), "3" },
                    { 17, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), "200g" },
                    { 18, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), "100g" },
                    { 19, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), "150g" },
                    { 20, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), "to taste" },
                    { 3, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "to taste" },
                    { 5, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "3 tbsp" },
                    { 9, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "2" },
                    { 10, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "1 tbsp" },
                    { 21, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "1" },
                    { 22, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "1" },
                    { 23, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "100g" },
                    { 24, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "1 tsp" },
                    { 25, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), "50g" },
                    { 12, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), "200g" },
                    { 33, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), "1 packet" },
                    { 34, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), "4" },
                    { 35, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), "1 cup, shredded" },
                    { 36, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), "1 cup, shredded" },
                    { 37, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), "1/2 cup" },
                    { 38, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), "1 cup" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 1, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 14, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 1, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 3, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 27, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 1, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 6, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 3, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 9, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 1, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 28, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumns: new[] { "CategoryId", "RecipeId" },
                keyValues: new object[] { 29, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeCuisines",
                keyColumns: new[] { "CuisineId", "RecipeId" },
                keyValues: new object[] { 2, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeCuisines",
                keyColumns: new[] { "CuisineId", "RecipeId" },
                keyValues: new object[] { 1, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeCuisines",
                keyColumns: new[] { "CuisineId", "RecipeId" },
                keyValues: new object[] { 1, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") });

            migrationBuilder.DeleteData(
                table: "RecipeCuisines",
                keyColumns: new[] { "CuisineId", "RecipeId" },
                keyValues: new object[] { 9, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeCuisines",
                keyColumns: new[] { "CuisineId", "RecipeId" },
                keyValues: new object[] { 3, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 29, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"));

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"));

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"));

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("c1b3e572-59a1-4e3e-8a5f-7f4a9b5e2c58"));

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("d4e4a728-8b91-4c8f-9e7d-c2f918c3b8b5"));

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("e7b2a0de-5f15-4e7f-89f3-2a8e0c3e07d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"));

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Recipes",
                newName: "Titile");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 29, 22, 34, 33, 571, DateTimeKind.Utc).AddTicks(5341), "$2a$11$NKxXBpu0i9OFP5bAasS4ReP/d3F/UxDvA..frIy.AYvIyYTNG9QRC" });
        }
    }
}
