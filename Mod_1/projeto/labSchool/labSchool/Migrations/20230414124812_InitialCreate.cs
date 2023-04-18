using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    Experiência = table.Column<string>(type: "TEXT", nullable: false),
                    Formação_Acadêmica = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Codigo", "CPF", "Data_Nascimento", "Nome", "Nota", "Situação_Matrícula", "Telefone" },
                values: new object[,]
                {
                    { 1, "11839750073", new DateTime(2014, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bart Simpson", 3.5f, "IRREGULAR", "11-11111-1212" },
                    { 2, "17158947076", new DateTime(2012, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa Simpson", 10f, "ATIVO", "11-22222-2222" },
                    { 3, "63701210020", new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meggie Simpson", 9f, "ATIVO", "12-20002-2200" },
                    { 4, "30119137062", new DateTime(2014, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milhouse Van Houten", 8f, "ATIVO", "11-33333-2222" },
                    { 5, "95704094015", new DateTime(2007, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson Muntz", 2f, "INATIVO", "11-44333-4444" }
                });

            migrationBuilder.InsertData(
                table: "Pedagogo",
                columns: new[] { "Codigo", "CPF", "Data_Nascimento", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "62316840086", new DateTime(2000, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Snow", "11-67333-4454" },
                    { 2, "49850253053", new DateTime(2004, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sansa Stark", "22-22333-4454" },
                    { 3, "39125106015", new DateTime(1990, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyrion Lannister", "33-77333-4454" },
                    { 4, "89089606009", new DateTime(1995, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandor Clegane", "11-33333-2222" }
                });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Codigo", "CPF", "Data_Nascimento", "Estado", "Experiência", "Formação_Acadêmica", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "40539019011", new DateTime(1982, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ATIVO", "FULL_STACK", "MESTRADO", "Walter White", "14-22998-1882" },
                    { 2, "96107295097", new DateTime(1997, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ATIVO", "BACK_END", "GRADUAÇÃO_INCOMPLETA", "Jesse Pinkman", "44-11111-1992" },
                    { 3, "70685977005", new DateTime(1984, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ATIVO", "FULL_STACK", "MESTRADO", "Hank Schrader", "44-11111-1002" },
                    { 4, "57408927085", new DateTime(1977, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "INATIVO", "FRONT_END", "GRADUAÇÃO_COMPLETA", "Gustavo Fring", "44-11001-1002" },
                    { 5, "86940162062", new DateTime(1980, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ATIVO", "FULL_STACK", "MESTRADO", "Saul Goodman", "44-11998-1882" }
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
