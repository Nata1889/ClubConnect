using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubConnect.Migrations
{
    /// <inheritdoc />
    public partial class cambioModeloSocio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "socios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "reservas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Estado",
                value: "Confirmado");

            migrationBuilder.UpdateData(
                table: "socios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telefono",
                value: "3498517621");

            migrationBuilder.UpdateData(
                table: "socios",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telefono",
                value: "3498431264");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Telefono",
                table: "socios",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "reservas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Estado",
                value: "Condirmado");

            migrationBuilder.UpdateData(
                table: "socios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telefono",
                value: 3498517621L);

            migrationBuilder.UpdateData(
                table: "socios",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telefono",
                value: 3498431264L);
        }
    }
}
