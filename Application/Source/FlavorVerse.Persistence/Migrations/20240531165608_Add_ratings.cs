using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_ratings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 56, 7, 788, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 56, 7, 788, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "CreatedAt", "DeletedAt", "DeletedBy", "ModifiedAt", "ModifiedBy", "RatingValue", "RecipeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"), "Delicious!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 10, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212") },
                    { new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"), "A bit too spicy for my taste.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 6, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") },
                    { new Guid("4b86773a-092e-4554-88fe-74743a78973c"), "Authentic flavors!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 7, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212") },
                    { new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"), "Tastes like authentic street tacos!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 8, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"), new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") },
                    { new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"), "Healthy and delicious!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212") },
                    { new Guid("68513c99-a253-4098-b52a-2d65c3048992"), "Classic dish!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") },
                    { new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"), "Could use more seasoning.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 7, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") },
                    { new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"), "Could use more sauce.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 4, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") },
                    { new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"), "Tasty!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 10, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212") },
                    { new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"), "Simple and tasty.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 8, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") },
                    { new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"), "I didn't like it.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") },
                    { new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"), "Quick and easy dinner!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"), new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") },
                    { new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"), "Refreshing!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 6, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"), new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212") },
                    { new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"), "Could be more flavorful.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 3, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"), new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") },
                    { new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"), "Great recipe!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 8, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"), new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 56, 7, 790, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 56, 7, 790, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 56, 7, 790, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 56, 7, 790, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 56, 7, 790, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 56, 7, 902, DateTimeKind.Utc).AddTicks(9494), "$2a$11$HFgz5zcKvzSZ3C8aDeUdkeqAESCHcGY3ZqlBqI/FJd6.g25/pJ/Ie" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 56, 8, 236, DateTimeKind.Utc).AddTicks(6184), "$2a$11$0PeGw3VezgPuDBHFWEwuxe7/1ddve/.lZmX6m1ivMW/JjPAYgBWRO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 56, 8, 128, DateTimeKind.Utc).AddTicks(3293), "$2a$11$ijD2y1H4QcH2F9r1A9i7Ouqd9CRVqQt1L5QTNns0jUVZQteMmOhk2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 56, 8, 17, DateTimeKind.Utc).AddTicks(3907), "$2a$11$pCfHNPWgdtSNQTEVfFHjseQ7LCqP8cBpyk1wkt7d1xbRm.oRAXRDe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4b86773a-092e-4554-88fe-74743a78973c"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("68513c99-a253-4098-b52a-2d65c3048992"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 32, 13, 235, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 32, 13, 235, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 32, 13, 237, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 32, 13, 237, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 32, 13, 237, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 32, 13, 237, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 32, 13, 237, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 32, 13, 349, DateTimeKind.Utc).AddTicks(317), "$2a$11$gG16T9hCt2Hkwbc3Pg6nkOG29dzyteR7j.WIkfUvuYA/AoHfM77xy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 32, 13, 673, DateTimeKind.Utc).AddTicks(7980), "$2a$11$hvnNqlgXBlFiCiFZkQWxy.4ttDJQVPtEnmB74puYhYmSulxtDqYZu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 32, 13, 567, DateTimeKind.Utc).AddTicks(7773), "$2a$11$xROK0aohEx8xVg95IQtEruDKb0POqdAYLxGfygIVE0HP498uTicnC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 32, 13, 459, DateTimeKind.Utc).AddTicks(6722), "$2a$11$G.IiyCCsxGVaFK5Sj66IPOMa0oflcSuF5BxdZzsctDrgAEL8eeUEi" });
        }
    }
}
