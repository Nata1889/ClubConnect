using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubConnect.Migrations
{
    /// <inheritdoc />
    public partial class creacionDeDatosSemilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "socios",
                columns: new[] { "Id", "Apellido", "Direccion", "Email", "FechaDeIngresoAlClub", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 1, "Sasia", "San Martín 2698", "natanaelsasia@gmail.com", "23/01/2022", "07/03/2001", "Natanael", 3498517621L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "socios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
