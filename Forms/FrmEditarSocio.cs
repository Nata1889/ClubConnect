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
    public partial class FrmEditarSocio : Form
    {
        int idSocioEditado;
        Socio? socio;
        public FrmEditarSocio(int idSocioAEditar)
        {
            InitializeComponent();
            this.idSocioEditado = idSocioAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            ClubConnectContext context = new ClubConnectContext();
            socio = context.socios.Find(idSocioEditado);

            if (socio != null)
            {
                txtNombre.Text = socio.Nombre;
                txtApellido.Text = socio.Apellido;
                txtFechaNacimiento.Text = socio.FechaNacimiento;
                txtDireccion.Text = socio.Direccion;
                txtTelefono.Text = socio.Telefono;
                txtEmail.Text = socio.Email;
                txtFechaDeIngreso.Text = socio.FechaDeIngresoAlClub;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClubConnectContext context = new ClubConnectContext();
            socio.Nombre = txtNombre.Text;
            socio.Apellido = txtApellido.Text;
            socio.FechaNacimiento = txtFechaNacimiento.Text;
            socio.Direccion = txtDireccion.Text;
            socio.Telefono = txtTelefono.Text;
            socio.Email = txtEmail.Text;
            socio.FechaDeIngresoAlClub = txtFechaDeIngreso.Text;
            context.Entry(socio).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }
    }
}
