using ClubConnect.Data;
using ClubConnect.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class FrmEditarInstalacion : Form
    {
        int idInstalacionEditada;
        Instalacion? instalacion;
        public FrmEditarInstalacion(int idInstalacionEditar)
        {
            InitializeComponent();
            this.idInstalacionEditada = idInstalacionEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            ClubConnectContext context = new ClubConnectContext();
            instalacion = context.instalaciones.Find(idInstalacionEditada);
            if (instalacion != null)
            {
                txtNombreDeLaInstalacion.Text = instalacion.NombreDeLaInstalacion;
                txtDescripcion.Text = instalacion.Descripcion;
                txtDisponibilidad.Text = instalacion.Disponibilidad;
                txtCostoDeLaReserva.Text = instalacion.CostoDeReserva;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClubConnectContext context = new ClubConnectContext();
            instalacion.NombreDeLaInstalacion = txtNombreDeLaInstalacion.Text;
            instalacion.Descripcion = txtDescripcion.Text;
            instalacion.Disponibilidad = txtDisponibilidad.Text;
            instalacion.CostoDeReserva = txtCostoDeLaReserva.Text;

            context.Entry(instalacion).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }
    }
}
