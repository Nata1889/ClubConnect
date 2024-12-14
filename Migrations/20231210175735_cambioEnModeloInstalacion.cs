using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubConnect.Migrations
{
    /// <inheritdoc />
    public partial class cambioEnModeloInstalacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CostoDeReserva",
                table: "instalaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "instalaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CostoDeReserva",
                value: "9800");

            migrationBuilder.UpdateData(
                table: "instalaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CostoDeReserva",
                value: "3000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CostoDeReserva",
                table: "instalaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "instalaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CostoDeReserva",
                value: 9800);

            migrationBuilder.UpdateData(
                table: "instalaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CostoDeReserva",
                value: 3000);
        }
    }
}
