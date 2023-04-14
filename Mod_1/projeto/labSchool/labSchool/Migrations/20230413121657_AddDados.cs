using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labSchool.Migrations
{
    /// <inheritdoc />
    public partial class AddDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Adicionando dados
            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Nome", "Telefone", "Data_Nascimento", "CPF", "Situação_Matrícula", "Nota", "Atendimentos" },
                values: new object[,]
                {
                    {"Bart Simpson", "11-11111-1212", new DateTime(2014, 10, 29), "11839750073", "IRREGULAR", 3.5, 0},
                    {"Lisa Simpson", "11-22222-2222", new DateTime(2012, 10, 29), "17158947076", "ATIVO", 10, 0},
                    {"Meggie Simpson", "12-20002-2200", new DateTime(2019, 10, 29), "63701210020", "ATIVO", 9, 0},
                    {"Milhouse Van Houten", "11-33333-2222", new DateTime(2014, 10, 29), "30119137062", "ATIVO", 8, 0},
                    {"Nelson Muntz", "11-44333-4444", new DateTime(2007, 10, 29), "95704094015", "INATIVO", 2, 0}
                }
            );

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Nome", "Telefone", "Data_Nascimento", "CPF", "Formação_Acadêmica", "Experiência", "Estado" },
                values: new object[,]
                {
                    {"Walter White", "14-22998-1882", new DateTime(1982, 10, 30), "40539019011", "MESTRADO", "FULL_STACK", "ATIVO"},
                    {"Jesse Pinkman", "44-11111-1992", new DateTime(1997, 10, 30), "96107295097", "GRADUAÇÃO_INCOMPLETA", "BACK_END", "ATIVO"},
                    {"Hank Schrader", "44-11111-1002", new DateTime(1984, 10, 30), "70685977005", "MESTRADO", "FULL_STACK", "ATIVO"},
                    {"Gustavo Fring", "44-11001-1002", new DateTime(1977, 10, 30), "57408927085", "GRADUAÇÃO_COMPLETA", "FRONT_END", "INATIVO"},
                    {"Saul Goodman", "44-11998-1882", new DateTime(1980, 10, 30), "86940162062", "MESTRADO", "FULL_STACK", "ATIVO"}
                }
            );

            migrationBuilder.InsertData(
                table: "Pedagogo",
                columns: new[] { "Nome", "Telefone", "Data_Nascimento", "CPF", "Atendimentos" },
                values: new object[,]
                {
                    {"John Snow", "11-67333-4454", new DateTime(2000, 10, 30), "62316840086", 0},
                    {"Sansa Stark", "22-22333-4454", new DateTime(2004, 10, 30), "49850253053", 0},
                    {"Tyrion Lannister", "33-77333-4454", new DateTime(1990, 10, 30), "39125106015", 0},
                    {"Sandor Clegane", "11-33333-2222", new DateTime(1995, 10, 30), "89089606009", 0},
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
