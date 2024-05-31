using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_user_roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") },
                    { 2, new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") },
                    { 1, new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212") },
                    { 1, new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08") });

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 28, 47, 327, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 28, 47, 327, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 28, 47, 329, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 28, 47, 329, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 28, 47, 329, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 28, 47, 329, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 28, 47, 329, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 28, 47, 446, DateTimeKind.Utc).AddTicks(1198), "$2a$11$/TlmEnj5.1rGXFDeyoYHZuBvgMpR5nc5jC4wEghNCH7fBFENfluUa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 28, 47, 779, DateTimeKind.Utc).AddTicks(9028), "$2a$11$vD3lI4PY/LXhAANTgkaROeu0GCRLrNEutG8IVpdu700FT9cZUYSii" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 28, 47, 671, DateTimeKind.Utc).AddTicks(8412), "$2a$11$MnQ3wSZQSSkMIJETRcRghOG/adOrbB1yOc8GSFYG02IOPibv.4M4y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 28, 47, 561, DateTimeKind.Utc).AddTicks(7355), "$2a$11$x5toyZk4PREyC1MQdKMOrO9Z4c0SV2i/ioeYWMcpS8Rxs8Q8UmIWW" });
        }
    }
}
