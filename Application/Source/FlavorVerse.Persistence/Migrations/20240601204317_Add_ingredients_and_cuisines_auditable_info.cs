using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_ingredients_and_cuisines_auditable_info : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Ingredients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Ingredients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Ingredients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Ingredients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Cuisines",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Cuisines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cuisines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Cuisines",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Cuisines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5056), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5059), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5060), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5061), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5063), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5064), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5065), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5066), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5067), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5069), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5070), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5071), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5072), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5073), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5074), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(5075), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9178), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9180), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9181), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9182), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9183), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9184), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9185), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9186), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9187), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9188), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9189), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9190), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9191), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9192), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9193), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9194), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9195), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9196), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9197), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9198), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9199), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9200), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9201), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9202), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9203), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9203), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9204), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9205), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9206), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9207), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9208), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9209), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9210), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9220), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9222), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9223), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9224), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 184, DateTimeKind.Utc).AddTicks(9225), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 185, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 185, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 21, 16, 185, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 185, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4b86773a-092e-4554-88fe-74743a78973c"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 10, 43, 16, 185, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 17, 43, 16, 185, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 185, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("68513c99-a253-4098-b52a-2d65c3048992"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 185, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 10, 43, 16, 185, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 19, 43, 16, 185, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 185, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 185, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 19, 43, 16, 185, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 31, 22, 43, 16, 185, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 19, 53, 16, 185, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 33, 16, 185, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 19, 46, 16, 185, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 187, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 187, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 187, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 187, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 20, 43, 16, 187, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 299, DateTimeKind.Utc).AddTicks(5845), "$2a$11$idoq8f62GAjcT8bSv.L2NOxNcovcRfETei9Yjgl/xLRbBRtPhG8K2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 637, DateTimeKind.Utc).AddTicks(7231), "$2a$11$nbPvny20WrOnISyZ/aXiAOp9nZ3C5IFM.4kxxTVe0Cr8qkDkwH9A2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 524, DateTimeKind.Utc).AddTicks(7289), "$2a$11$QpNYnsZzwht91A98miykTeeIv/XjWvQNyxSZDJI/46xSrWZfP2/y." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 43, 16, 412, DateTimeKind.Utc).AddTicks(3244), "$2a$11$kIHW9cyNzEM.t2GS5JNcSuzuEIb2K9ccdXyWFHhrRMGQb6Y7g/8Hq" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cuisines");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Cuisines");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Cuisines");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cuisines");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Cuisines");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Cuisines");

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
    }
}
