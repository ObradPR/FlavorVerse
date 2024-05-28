using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorVerse.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Edit_audit_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audits_Users_ExecutedBy",
                table: "Audits");

            migrationBuilder.RenameColumn(
                name: "ExecutedBy",
                table: "Audits",
                newName: "ExecutedById");

            migrationBuilder.RenameIndex(
                name: "IX_Audits_ExecutedBy",
                table: "Audits",
                newName: "IX_Audits_ExecutedById");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 54, 11, 258, DateTimeKind.Utc).AddTicks(5541), "$2a$11$oAPhpRAyBlYamMeHQ75C/uAMesuiB0bP0ttaNditkQyoQJLVjTdg2" });

            migrationBuilder.AddForeignKey(
                name: "FK_Audits_Users_ExecutedById",
                table: "Audits",
                column: "ExecutedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audits_Users_ExecutedById",
                table: "Audits");

            migrationBuilder.RenameColumn(
                name: "ExecutedById",
                table: "Audits",
                newName: "ExecutedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Audits_ExecutedById",
                table: "Audits",
                newName: "IX_Audits_ExecutedBy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2024, 5, 28, 19, 49, 47, 192, DateTimeKind.Utc).AddTicks(5175), "$2a$11$KPZMfDHZUNAc1yL1F208oObcsL/44NUkwF5iFjEd9voMO//6vEwqW" });

            migrationBuilder.AddForeignKey(
                name: "FK_Audits_Users_ExecutedBy",
                table: "Audits",
                column: "ExecutedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
