using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Models
{
    public enum EstadoReserva
    {
        Pendiente,
        Confirmada,
        Cancelada
    }

    public class Reserva
    {
        public int Id { get; set; }
        public string? FechaYHoraDeInicio { get; set; }
        public string? FechaYHoraDeFin { get; set; }


        public EstadoReserva Estado { get; set; }
        public int? SocioId { get; set; }
        public Socio Socio { get; set; }
        public int? InstalacionId { get; set; }
        public Instalacion Instalacion { get; set; }

        public override string ToString()
        {
            return FechaYHoraDeInicio + SocioId + Instalacion;
        }
    }
}
