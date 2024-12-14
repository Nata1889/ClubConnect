using ClubConnect.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Data
{
    public class ClubConnectContext : DbContext
    {
        public DbSet<Socio> socios {get; set;}
        public DbSet<Membresia> membresias { get; set;}
        public DbSet<Instalacion>  instalaciones { get; set;}
        public DbSet<Reserva> reservas { get; set;}
        public DbSet<Evento> eventos { get; set;}

        public ClubConnectContext()
        {
            
        }

        public ClubConnectContext(DbContextOptions<ClubConnectContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string CadenaConexion = "Server=.\\SQLEXPRESS;" +
                "User=sa;" +
                "Password=123;" +
                "Database=ClubConnectContext;" +
                "MultipleActiveResultSets=True;" +
                "Encrypt=False";
            optionsBuilder.UseSqlServer(CadenaConexion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Socio>().HasData(
                new Socio()
                { Id = 1, Nombre = "Natanael", Apellido = "Sasia", FechaNacimiento = "07/03/2001", Direccion = "San Martín 2698", Telefono = "3498517621", Email = "natanaelsasia@gmail.com", FechaDeIngresoAlClub = "24/01/2022" },
                new Socio()
                { Id = 2, Nombre = "Ezequiel", Apellido = "Porchietto", FechaNacimiento = "14/02/1977", Direccion = "J. Mantovani 1684", Telefono = "3498431264", Email = "ezeporchietto@gmail.com", FechaDeIngresoAlClub = "23/08/2015" });

            modelBuilder.Entity<Membresia>().HasData(
                new Membresia()
                { Id = 1, TipoDeMembresia = "Asociado", FechaDeInicio = "24/01/2022", FechaDeExpiracion = "24/12/2023", Estado = "Activo", SocioId = 1 },
                new Membresia()
                {
                    Id = 2,
                    TipoDeMembresia = "Afiliado",
                    FechaDeInicio = "23/08/2015",
                    FechaDeExpiracion = "23712/2023",
                    Estado = "Activo",
                    SocioId = 2
                });

            modelBuilder.Entity<Instalacion>().HasData(
                new Instalacion()
                { Id = 1, NombreDeLaInstalacion = "Lionel Messi", Descripcion = "Cancha de Futbol 7", Disponibilidad = "Si", CostoDeReserva = "9800" },
                new Instalacion()
                { Id = 2, NombreDeLaInstalacion = "David Nalbandian", Descripcion = "Cancha de Tenis", Disponibilidad = "Si", CostoDeReserva = "3000" });

            _ = modelBuilder.Entity<Reserva>().HasData(
                new Reserva()
                { Id = 1, FechaYHoraDeInicio = "10/12/2023 - 19:00", FechaYHoraDeFin = "10/12/2023 - 20:00", Estado = EstadoReserva.Confirmada, SocioId = 1, InstalacionId = 1 },
                new Reserva()
                { Id = 2, FechaYHoraDeInicio = "10/12/2023 - 21:00", FechaYHoraDeFin = "10/12/2023 - 23:00", Estado = EstadoReserva.Confirmada, SocioId = 2, InstalacionId = 2 });

            modelBuilder.Entity<Evento>().HasData(
                new Evento()
                { Id = 1, NombreDelEvento = "Copa Santa Fe", Descripcion = "Torneo de Futbol 11", FechaYhoraDelEvento = "09/03/2024 - Horario a definir", LugarDelEvento = "Club Colón de San Justo" },
                new Evento()
                { Id = 2, NombreDelEvento = "Argentina Open", Descripcion = "Torneo de Tenis", FechaYhoraDelEvento = "16/03/2024 - Horario a definir", LugarDelEvento = "Club Colón de San Justo" });
        }
    }
}
