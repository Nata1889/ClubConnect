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
    public partial class FrmNuevoSocio : Form
    {
        public FrmNuevoSocio()
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
            var socio = new Socio()
            {
                Nombre=txtNombre.Text,
                Apellido=txtApellido.Text,
                FechaNacimiento=txtFechaNacimiento.Text,
                Direccion=txtDireccion.Text,
                Telefono=txtTelefono.Text,
                Email=txtEmail.Text,
                FechaDeIngresoAlClub=txtFechaDeIngreso.Text
            };
            context.socios.Add( socio );
            context.SaveChanges();
            this.Close();
        }
    }
}
