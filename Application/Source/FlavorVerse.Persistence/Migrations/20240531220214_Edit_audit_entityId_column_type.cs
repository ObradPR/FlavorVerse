using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Edit_audit_entityId_column_type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EntityId",
                table: "Audits",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 811, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 812, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 812, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 21, 40, 13, 813, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 813, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4b86773a-092e-4554-88fe-74743a78973c"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 12, 2, 13, 813, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 19, 2, 13, 813, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 813, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("68513c99-a253-4098-b52a-2d65c3048992"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 813, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 12, 2, 13, 813, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 21, 2, 13, 813, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 813, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 813, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 21, 2, 13, 813, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 0, 2, 13, 813, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 21, 12, 13, 813, DateTimeKind.Utc).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 21, 52, 13, 813, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 21, 5, 13, 813, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 815, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 815, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 815, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 815, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 2, 13, 815, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 22, 2, 13, 926, DateTimeKind.Utc).AddTicks(7853), "$2a$11$AVrxvCqCL5tDw.pddvJpruUmeBNw3MSrbe8aSdntz5.X91OauYP4i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 22, 2, 14, 267, DateTimeKind.Utc).AddTicks(4301), "$2a$11$Ed8rwwUHH1ms/4STBYNHz.EvFBjBrM9kQq0RPEeFYHXfC6.xG4FpK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 22, 2, 14, 156, DateTimeKind.Utc).AddTicks(8223), "$2a$11$uSDBNX6IWz3jOHUCgHtol.Rs41PRk39VtVYq7YfVml/Qi3yBSCqNy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 31, 22, 2, 14, 43, DateTimeKind.Utc).AddTicks(2675), "$2a$11$N3YV3SXGIeopiQGrz8sBEeIfVluEWMeqIrwmyZsS0C5mdZmos.kYy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "EntityId",
                table: "Audits",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 20, 55, 1, 306, DateTimeKind.Utc).AddTicks(8410));

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
    }
}
