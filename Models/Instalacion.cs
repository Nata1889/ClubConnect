using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Models
{
    public class Instalacion
    {
        public int Id { get; set; }
        public string NombreDeLaInstalacion { get; set; }
        public string? Descripcion { get; set; }
        public string? Disponibilidad { get; set; }
        public string? CostoDeReserva { get; set; }

        public override string ToString()
        {
            return NombreDeLaInstalacion + " " + Descripcion;
        }
    }
}
