using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurantes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoDaEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecoMedioPorRefeicao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiasPresenciais = table.Column<int>(type: "int", nullable: false),
                    ValorDoValeRefeicao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "CreatedDate", "DiasPresenciais", "EnderecoDaEmpresa", "Nome", "PrecoMedioPorRefeicao", "ValorDoValeRefeicao" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 19, 13, 45, 7, 391, DateTimeKind.Local).AddTicks(1173), 10, "Rua Jorge Beretta", "Eriberto Lima", 5000000m, 2.000m },
                    { 2, new DateTime(2024, 6, 19, 13, 45, 7, 391, DateTimeKind.Local).AddTicks(1197), 20, "Street 10", "Jhon Dee", 5000000m, 1.000m },
                    { 3, new DateTime(2024, 6, 19, 13, 45, 7, 391, DateTimeKind.Local).AddTicks(1198), 10, "Rua beltrano azevedo", "Fulano de tal", 5000000m, 500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
