using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_rating_times : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4b86773a-092e-4554-88fe-74743a78973c"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("68513c99-a253-4098-b52a-2d65c3048992"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
