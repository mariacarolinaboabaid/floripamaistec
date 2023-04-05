using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ex_003.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mae", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Crm = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Celular = table.Column<int>(type: "INTEGER", nullable: false),
                    Especialidade = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data_Parto = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Horario_Parto = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Medico_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MEDICO_PARTO",
                        column: x => x.Medico_Id,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bebe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data_Nascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Peso_Nascimento = table.Column<decimal>(type: "TEXT", precision: 4, scale: 3, nullable: false),
                    Altura = table.Column<int>(type: "INTEGER", nullable: false),
                    Mae_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Parto_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MAE_BEBE",
                        column: x => x.Mae_Id,
                        principalTable: "Mae",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PARTO_BEBE",
                        column: x => x.Parto_Id,
                        principalTable: "Parto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_Mae_Id",
                table: "Bebe",
                column: "Mae_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_Parto_Id",
                table: "Bebe",
                column: "Parto_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Parto_Medico_Id",
                table: "Parto",
                column: "Medico_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebe");

            migrationBuilder.DropTable(
                name: "Mae");

            migrationBuilder.DropTable(
                name: "Parto");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
