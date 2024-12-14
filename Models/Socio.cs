﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Models
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? FechaDeIngresoAlClub { get; set; }

        public override string ToString()
        {
            return Nombre +" "+  Apellido;
        }
    }
}
