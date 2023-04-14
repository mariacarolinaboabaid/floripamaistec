using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ex_sem10.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Periodo = table.Column<int>(type: "INTEGER", nullable: false),
                    Ra = table.Column<int>(type: "INTEGER", nullable: false),
                    User_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserId_Student",
                        column: x => x.User_id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Departament = table.Column<string>(type: "TEXT", nullable: false),
                    User_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserId_Teacher",
                        column: x => x.User_id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discipline_name = table.Column<string>(type: "TEXT", nullable: false),
                    Teacher_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherId_Discipline",
                        column: x => x.Teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Date_open = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Date_close = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Discipline_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisciplineId_Quiz",
                        column: x => x.Discipline_id,
                        principalTable: "Discipline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student_Discipline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Student_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Discipline_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Discipline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisciplineId",
                        column: x => x.Discipline_id,
                        principalTable: "Discipline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentId",
                        column: x => x.Student_id,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Enunciation = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quiz_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizId_Question",
                        column: x => x.Quiz_id,
                        principalTable: "Quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Response = table.Column<string>(type: "TEXT", nullable: false),
                    Score = table.Column<float>(type: "REAL", nullable: false),
                    Observation = table.Column<string>(type: "TEXT", nullable: false),
                    Student_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Question_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionId_Answer",
                        column: x => x.Question_id,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentId_Answer",
                        column: x => x.Student_id,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_Question_id",
                table: "Answer",
                column: "Question_id");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_Student_id",
                table: "Answer",
                column: "Student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_Teacher_id",
                table: "Discipline",
                column: "Teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Quiz_id",
                table: "Question",
                column: "Quiz_id");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_Discipline_id",
                table: "Quiz",
                column: "Discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_User_id",
                table: "Student",
                column: "User_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Discipline_Discipline_id",
                table: "Student_Discipline",
                column: "Discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Discipline_Student_id",
                table: "Student_Discipline",
                column: "Student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_User_id",
                table: "Teacher",
                column: "User_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Student_Discipline");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
