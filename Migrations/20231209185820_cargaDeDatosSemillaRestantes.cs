using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClubConnect.Migrations
{
    /// <inheritdoc />
    public partial class cargaDeDatosSemillaRestantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDelEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaYhoraDelEvento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LugarDelEvento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instalaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDeLaInstalacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostoDeReserva = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instalaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "membresias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeMembresia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeExpiracion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membresias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_membresias_socios_SocioId",
                        column: x => x.SocioId,
                        principalTable: "socios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaYHoraDeInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaYHoraDeFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocioId = table.Column<int>(type: "int", nullable: true),
                    InstalacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservas_instalaciones_InstalacionId",
                        column: x => x.InstalacionId,
                        principalTable: "instalaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_reservas_socios_SocioId",
                        column: x => x.SocioId,
                        principalTable: "socios",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "eventos",
                columns: new[] { "Id", "Descripcion", "FechaYhoraDelEvento", "LugarDelEvento", "NombreDelEvento" },
                values: new object[,]
                {
                    { 1, "Torneo de Futbol 11", "09/03/2024 - Horario a definir", "Club Colón de San Justo", "Copa Santa Fe" },
                    { 2, "Torneo de Tenis", "16/03/2024 - Horario a definir", "Club Colón de San Justo", "Argentina Open" }
                });

            migrationBuilder.InsertData(
                table: "instalaciones",
                columns: new[] { "Id", "CostoDeReserva", "Descripcion", "Disponibilidad", "NombreDeLaInstalacion" },
                values: new object[,]
                {
                    { 1, 9800, "Cancha de Futbol 7", "Si", "Lionel Messi" },
                    { 2, 3000, "Cancha de Tenis", "Si", "David Nalbandian" }
                });

            migrationBuilder.InsertData(
                table: "membresias",
                columns: new[] { "Id", "Estado", "FechaDeExpiracion", "FechaDeInicio", "SocioId", "TipoDeMembresia" },
                values: new object[] { 1, "Activo", "24/12/2023", "24/01/2022", 1, "Asociado" });

            migrationBuilder.UpdateData(
                table: "socios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDeIngresoAlClub",
                value: "24/01/2022");

            migrationBuilder.InsertData(
                table: "socios",
                columns: new[] { "Id", "Apellido", "Direccion", "Email", "FechaDeIngresoAlClub", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 2, "Porchietto", "J. Mantovani 1684", "ezeporchietto@gmail.com", "23/08/2015", "14/02/1977", "Ezequiel", 3498431264L });

            migrationBuilder.InsertData(
                table: "membresias",
                columns: new[] { "Id", "Estado", "FechaDeExpiracion", "FechaDeInicio", "SocioId", "TipoDeMembresia" },
                values: new object[] { 2, "Activo", "23712/2023", "23/08/2015", 2, "Afiliado" });

            migrationBuilder.InsertData(
                table: "reservas",
                columns: new[] { "Id", "Estado", "FechaYHoraDeFin", "FechaYHoraDeInicio", "InstalacionId", "SocioId" },
                values: new object[,]
                {
                    { 1, "Confirmado", "10/12/2023 - 20:00", "10/12/2023 - 19:00", 1, 1 },
                    { 2, "Condirmado", "10/12/2023 - 23:00", "10/12/2023 - 21:00", 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_membresias_SocioId",
                table: "membresias",
                column: "SocioId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_InstalacionId",
                table: "reservas",
                column: "InstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_SocioId",
                table: "reservas",
                column: "SocioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eventos");

            migrationBuilder.DropTable(
                name: "membresias");

            migrationBuilder.DropTable(
                name: "reservas");

            migrationBuilder.DropTable(
                name: "instalaciones");

            migrationBuilder.DeleteData(
                table: "socios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "socios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDeIngresoAlClub",
                value: "23/01/2022");
        }
    }
}
