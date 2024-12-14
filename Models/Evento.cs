using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string NombreDelEvento { get; set; }
        public string? Descripcion { get; set; }
        public string? FechaYhoraDelEvento { get; set; }
        public string? LugarDelEvento { get; set; }

        public override string ToString()
        {
            return NombreDelEvento;
        }
    }
}
