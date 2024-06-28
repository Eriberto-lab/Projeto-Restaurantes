using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurantes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUsuarioConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 19, 13, 50, 38, 334, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 19, 13, 50, 38, 334, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 19, 13, 50, 38, 334, DateTimeKind.Local).AddTicks(3554));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 19, 13, 45, 7, 391, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 19, 13, 45, 7, 391, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 19, 13, 45, 7, 391, DateTimeKind.Local).AddTicks(1198));
        }
    }
}
