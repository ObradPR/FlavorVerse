using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Edit_categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8352), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8356), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8358), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8359), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8361), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8362), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8364), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8371), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8373), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8374), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8375), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8377), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8378), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8379), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8380), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8382), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8383), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8385), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8386), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8387), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8388), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8390), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8402), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8403), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8404), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8406), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8407), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8408), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8410), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 307, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 307, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 33, 1, 308, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 308, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4b86773a-092e-4554-88fe-74743a78973c"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 10, 55, 1, 308, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 55, 1, 308, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 308, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("68513c99-a253-4098-b52a-2d65c3048992"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 308, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 10, 55, 1, 308, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 19, 55, 1, 308, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 308, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 308, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 19, 55, 1, 308, DateTimeKind.Utc).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 22, 55, 1, 308, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 5, 1, 308, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 45, 1, 308, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 19, 58, 1, 308, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 309, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 309, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 309, DateTimeKind.Utc).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 309, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 309, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 422, DateTimeKind.Utc).AddTicks(8499), "$2a$11$sbmaz86cY6BQojDCA4uBf.a.jues9rfszQR3W2gWlvenLEO8h6mkS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 751, DateTimeKind.Utc).AddTicks(6165), "$2a$11$qX.Zu2g2WNEYlfRgYb9iXu/ErABBXdLpzGXiAazyqEds/KpZ02i5S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 644, DateTimeKind.Utc).AddTicks(7069), "$2a$11$iBRRCmUd7DwT.IzSSKByjeemDuF8mqZsF.s937ktlCjDEj1opvgPy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 55, 1, 535, DateTimeKind.Utc).AddTicks(2912), "$2a$11$kTr7Xv5WL/aCXgPPH76Mw.d8tiVsCzrHxrFhVCdNk9g6K25AGJoie" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 587, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 587, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 39, 48, 587, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 587, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4b86773a-092e-4554-88fe-74743a78973c"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 7, 1, 48, 587, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 14, 1, 48, 587, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 587, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("68513c99-a253-4098-b52a-2d65c3048992"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 587, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 7, 1, 48, 587, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 1, 48, 587, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 587, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 587, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 1, 48, 587, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 19, 1, 48, 587, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 11, 48, 587, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 51, 48, 587, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 16, 4, 48, 587, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 589, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 589, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 589, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 589, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 17, 1, 48, 589, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 17, 1, 48, 700, DateTimeKind.Utc).AddTicks(3747), "$2a$11$PatAXFNg2ra8G2Vu9scLZeT1QWGHZ93XJ32L03KR/Sf0hv2SIbxvO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 17, 1, 49, 26, DateTimeKind.Utc).AddTicks(6870), "$2a$11$Z7uUC4LID3GVCQHWaie4k.iyWQiRy8uIkD8/zTVOSzdMiuc4DV40." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 17, 1, 48, 918, DateTimeKind.Utc).AddTicks(9069), "$2a$11$/3kfP0OJq335zg5vkAZzhO8OmfJhBmfcnyvDouWMoR7G8vweXp2Yi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 17, 1, 48, 809, DateTimeKind.Utc).AddTicks(406), "$2a$11$s.uHtR.wwJgfEH8Nw0StX.0wq6WEatKBR3DQpVBhLdMN2FJ7xA2Zm" });
        }
    }
}
