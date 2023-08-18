using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exerciciosAPI.Migrations
{
    /// <inheritdoc />
    public partial class RequiredFichaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FichaModels",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 17, 13, 26, 860, DateTimeKind.Local).AddTicks(5880),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 8, 17, 17, 12, 23, 846, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "DetalheModels",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 17, 13, 26, 860, DateTimeKind.Local).AddTicks(5680),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 8, 17, 17, 12, 23, 846, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "DetalheModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 8, 17, 17, 13, 26, 860, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "DetalheModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 8, 17, 17, 13, 26, 860, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "FichaModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 8, 17, 17, 13, 26, 860, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "FichaModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 8, 17, 17, 13, 26, 860, DateTimeKind.Local).AddTicks(5880));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FichaModels",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 17, 12, 23, 846, DateTimeKind.Local).AddTicks(630),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 8, 17, 17, 13, 26, 860, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "DetalheModels",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 17, 12, 23, 846, DateTimeKind.Local).AddTicks(410),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 8, 17, 17, 13, 26, 860, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "DetalheModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 8, 17, 17, 12, 23, 846, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "DetalheModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 8, 17, 17, 12, 23, 846, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "FichaModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 8, 17, 17, 12, 23, 846, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "FichaModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 8, 17, 17, 12, 23, 846, DateTimeKind.Local).AddTicks(630));
        }
    }
}
