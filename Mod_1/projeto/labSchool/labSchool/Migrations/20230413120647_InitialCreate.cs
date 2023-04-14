using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labSchool.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: false),
                    Situação_Matrícula = table.Column<string>(type: "TEXT", nullable: false),
                    Nota = table.Column<float>(type: "REAL", nullable: false),
                    Atendimentos = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Pedagogo",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: false),
                    Atendimentos = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedagogo", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: false),
                    Formação_Acadêmica = table.Column<string>(type: "TEXT", nullable: false),
                    Experiência = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Codigo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_CPF",
                table: "Aluno",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedagogo_CPF",
                table: "Pedagogo",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professor_CPF",
                table: "Professor",
                column: "CPF",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Pedagogo");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
