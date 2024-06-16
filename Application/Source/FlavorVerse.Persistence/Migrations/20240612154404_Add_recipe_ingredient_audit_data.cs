using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_recipe_ingredient_audit_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "RecipeIngredients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "RecipeIngredients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "RecipeIngredients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RecipeIngredients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "RecipeIngredients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "RecipeIngredients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 900, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 901, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 22, 3, 902, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 902, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4b86773a-092e-4554-88fe-74743a78973c"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 5, 44, 3, 902, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 12, 44, 3, 902, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 902, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("68513c99-a253-4098-b52a-2d65c3048992"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 902, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 5, 44, 3, 902, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 14, 44, 3, 902, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 902, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 902, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 14, 44, 3, 902, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 11, 17, 44, 3, 902, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 14, 54, 3, 902, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 34, 3, 902, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 14, 47, 3, 902, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7783), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7784), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7782), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7779), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7781), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 29, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7774), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7775), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7776), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7778), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7768), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7772), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7767), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7770), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7771), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7749), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7746), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7750), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7752), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7753), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7764), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7760), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7756), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7761), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7755), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7757), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7759), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7763), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, new Guid("4536c788-0357-4cd8-bac7-b94ca0562750") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7765), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7786), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7787), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7788), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7790), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7791), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7792), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6") },
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "ModifiedAt", "ModifiedBy" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 3, 909, DateTimeKind.Utc).AddTicks(7794), null, null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 904, DateTimeKind.Utc).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 904, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 904, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 904, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 15, 44, 3, 904, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 4, 19, DateTimeKind.Utc).AddTicks(9565), "$2a$11$dorxF7tuWfH63rvSKV8t1OFnk7tlfU1RU7Bsd27FNh7TYxLpdBbuy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 4, 343, DateTimeKind.Utc).AddTicks(4452), "$2a$11$EqRwlQ2RK2JEf8Pu8/7HpuQWtkXggrBKRNsmwUw9k0O4nV/5RtXk." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 4, 236, DateTimeKind.Utc).AddTicks(5663), "$2a$11$BtfV1I12PzfLNVhEF4gjUOQnL7C3/wJ/YyB4YjqN.pvIYYLXZYmvW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 4, 128, DateTimeKind.Utc).AddTicks(6238), "$2a$11$sX5sNRNF0oQKi2xL6rbne./5/dcqNIyruWihMKMtInF9Awo4Zpcze" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "RecipeIngredients");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 422, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: new Guid("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 423, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 14, 38, 424, DateTimeKind.Utc).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3923b038-e1ec-40af-bfd5-8470a4acd647"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 424, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4b86773a-092e-4554-88fe-74743a78973c"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 8, 36, 38, 424, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("54dea16a-6838-47f6-978b-0cff6def6b3e"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 15, 36, 38, 424, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("61bfc7f0-b242-46b1-a364-27887eb871a3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 424, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("68513c99-a253-4098-b52a-2d65c3048992"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 424, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("6de00555-feeb-4ad0-922d-25810973c8d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 8, 36, 38, 424, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 17, 36, 38, 424, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9e4b0164-0346-473e-9e79-a13623c975ca"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 424, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("abf7c036-c39c-4517-8fc6-2082dd5cf223"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 424, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 17, 36, 38, 424, DateTimeKind.Utc).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 20, 36, 38, 424, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e889e176-fb02-432c-bfff-c6617f4f58d0"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 17, 46, 38, 424, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec766a0f-a568-42a4-a566-5ffe39c42791"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 26, 38, 424, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fe403647-fc55-47a5-bdc8-d33966b2d883"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 17, 39, 38, 424, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 425, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 425, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 425, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4536c788-0357-4cd8-bac7-b94ca0562750"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 425, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 18, 36, 38, 425, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 5, 18, 36, 38, 537, DateTimeKind.Utc).AddTicks(2013), "$2a$11$Vxhqg6azVAdCda0mTT6EL.zez/Je4WaqOBGC2OpaaBj.uqDwFk/RC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 5, 18, 36, 38, 873, DateTimeKind.Utc).AddTicks(5360), "$2a$11$DigqlafWJzZHDtgoHlv9Y.zVSlkq0/zl6RZJ5EqM7SlarlL1qqEoq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 5, 18, 36, 38, 762, DateTimeKind.Utc).AddTicks(9580), "$2a$11$hEuu88x5FH8UJTBEvlwCe.cwDKF4vC.2raTm7ss9JZsIJT7NZNc4y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 6, 5, 18, 36, 38, 651, DateTimeKind.Utc).AddTicks(3481), "$2a$11$EhrHSvE7tnquqxq.WbG.eec/A.9Zss6BcVv51FqtSzhvEDFZMXemi" });
        }
    }
}
