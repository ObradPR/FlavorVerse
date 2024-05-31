using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "Password", "Phone" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 28, 47, 446, DateTimeKind.Utc).AddTicks(1198), "$2a$11$/TlmEnj5.1rGXFDeyoYHZuBvgMpR5nc5jC4wEghNCH7fBFENfluUa", "0000000000" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password", "Phone" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 28, 47, 671, DateTimeKind.Utc).AddTicks(8412), "$2a$11$MnQ3wSZQSSkMIJETRcRghOG/adOrbB1yOc8GSFYG02IOPibv.4M4y", "0646464646" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password", "Phone" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 28, 47, 561, DateTimeKind.Utc).AddTicks(7355), "$2a$11$x5toyZk4PREyC1MQdKMOrO9Z4c0SV2i/ioeYWMcpS8Rxs8Q8UmIWW", "0661261261" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "FirstName", "LastName", "ModifiedAt", "ModifiedBy", "Password", "Phone" },
                values: new object[] { new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"), new DateTime(2024, 5, 31, 16, 28, 47, 779, DateTimeKind.Utc).AddTicks(9028), new DateOnly(2002, 10, 10), null, null, "branko.pr@gmail.com", "Branko", "Pualić-Radujko", null, null, "$2a$11$vD3lI4PY/LXhAANTgkaROeu0GCRLrNEutG8IVpdu700FT9cZUYSii", "0612323232" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 22, 35, 501, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 22, 35, 501, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 22, 35, 504, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password", "Phone" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 22, 35, 620, DateTimeKind.Utc).AddTicks(5513), "$2a$11$pNqdjoHO519QIRwNGHnMjOgUJLV.OnR.g6sc2uo54G4Zh7FXW9Dlm", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password", "Phone" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 22, 35, 859, DateTimeKind.Utc).AddTicks(4829), "$2a$11$o9yzxPodULbYWHPoKvx5.OXxfYR3B3qow62ysFbEkniN8x419uCHi", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password", "Phone" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 22, 35, 743, DateTimeKind.Utc).AddTicks(8648), "$2a$11$dNbKJWNWQWSWGTgUsALAt.UiXRqelq1JfDCzV6CTTAc0FMTcyFfxi", "" });
        }
    }
}
