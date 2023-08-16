using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exerciciosAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FichaModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalheModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedBack = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    FichaId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalheModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalheModels_FichaModels_FichaId",
                        column: x => x.FichaId,
                        principalTable: "FichaModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TelefoneModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDD = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    FichaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefoneModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelefoneModels_FichaModels_FichaId",
                        column: x => x.FichaId,
                        principalTable: "FichaModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalheModels_FichaId",
                table: "DetalheModels",
                column: "FichaId");

            migrationBuilder.CreateIndex(
                name: "IX_TelefoneModels_FichaId",
                table: "TelefoneModels",
                column: "FichaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalheModels");

            migrationBuilder.DropTable(
                name: "TelefoneModels");

            migrationBuilder.DropTable(
                name: "FichaModels");
        }
    }
}
