using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 8, 30, 9, 12, 19, 336, DateTimeKind.Local).AddTicks(8390))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalheModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FeedBack = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    Nota = table.Column<int>(type: "INTEGER", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    FichaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 8, 30, 9, 12, 19, 336, DateTimeKind.Local).AddTicks(8200))
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DDD = table.Column<string>(type: "VARCHAR", maxLength: 3, nullable: false),
                    Numero = table.Column<string>(type: "VARCHAR", maxLength: 9, nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    FichaId = table.Column<int>(type: "INTEGER", nullable: false)
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

            migrationBuilder.InsertData(
                table: "FichaModels",
                columns: new[] { "Id", "DataNascimento", "Email", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "carolkboabaid@gmail.com", "Maria Boabaid" },
                    { 2, new DateTime(1995, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexandrenolla@gmail.com", "Alexandre Nolla" }
                });

            migrationBuilder.InsertData(
                table: "DetalheModels",
                columns: new[] { "Id", "Ativo", "FeedBack", "FichaId", "Nota" },
                values: new object[,]
                {
                    { 1, true, "Maravilhoso", 1, 5 },
                    { 2, true, "Ótimo!", 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "TelefoneModels",
                columns: new[] { "Id", "Ativo", "DDD", "FichaId", "Numero" },
                values: new object[,]
                {
                    { 1, true, "048", 1, "999337729" },
                    { 2, true, "048", 2, "999448899" }
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
