using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Audit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    ActionTypeId = table.Column<int>(type: "int", nullable: false),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false),
                    DetailsJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExecutedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExecutionTimeInMs = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audits_ActionTypes_lu_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes_lu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_EntityTypes_lu_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalTable: "EntityTypes_lu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_Users_ExecutedBy",
                        column: x => x.ExecutedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 59, 52, 996, DateTimeKind.Utc).AddTicks(3645), "$2a$11$PL7okcv9tL1T0vFGfBN7AO6Uqcczh/FhsRFtSL8/J8wQ5lqWQmC52" });

            migrationBuilder.CreateIndex(
                name: "IX_Audits_ActionTypeId",
                table: "Audits",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_EntityTypeId",
                table: "Audits",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_ExecutedBy",
                table: "Audits",
                column: "ExecutedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 54, 37, 361, DateTimeKind.Utc).AddTicks(5276), "$2a$11$.lrLKvB7zs0/e8h5nAn5yewSU06hVhLciXfqpTqcSWn4j/QN.yIG." });
        }
    }
}
