using ClubConnect.Data;
using ClubConnect.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubConnect.Forms
{
    public partial class FrmNuevaInstalacion : Form
    {
        public FrmNuevaInstalacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClubConnectContext context = new ClubConnectContext();
            var instalacion = new Instalacion()
            {
                NombreDeLaInstalacion = txtNombreDeLaInstalacion.Text,
                Descripcion = txtDescripcion.Text,
                Disponibilidad = txtDisponibilidad.Text,
                CostoDeReserva = txtCostoDeLaReserva.Text
            };
            context.instalaciones.Add(instalacion);
            context.SaveChanges();
            this.Close();
        }


    }
}
