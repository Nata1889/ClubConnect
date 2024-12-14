using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubConnect.Migrations
{
    /// <inheritdoc />
    public partial class ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Estado",
                table: "reservas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "reservas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Estado",
                value: 1);

            migrationBuilder.UpdateData(
                table: "reservas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Estado",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "reservas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "reservas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Estado",
                value: "Confirmado");

            migrationBuilder.UpdateData(
                table: "reservas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Estado",
                value: "Confirmado");
        }
    }
}
