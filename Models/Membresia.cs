using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Models
{
    public class Membresia
    {
        public int Id { get; set; }
        public string TipoDeMembresia { get; set; }
        public string? FechaDeInicio { get; set; }
        public string? FechaDeExpiracion { get; set; }
        public string? Estado { get; set; }
        public int? SocioId { get; set; }
        public Socio? Socio { get; set; }

        public override string ToString()
        {
            return TipoDeMembresia;
        }
    }
}
