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
    public partial class FrmNuevaMembresia : Form
    {
        ClubConnectContext context = new ClubConnectContext();
        public FrmNuevaMembresia()
        {
            InitializeComponent();
            CargarCboSocios();
        }

        private void CargarCboSocios()
        {
            cboSocio.DataSource = context.socios.ToList();
            cboSocio.DisplayMember = "Nombre";
            cboSocio.ValueMember = "Id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClubConnectContext context = new ClubConnectContext();
            var membresia = new Membresia()

            {
                TipoDeMembresia = txtTipoDeMembresia.Text,
                FechaDeInicio = txtFechaDeInicio.Text,
                FechaDeExpiracion = txtFechaDeExpiración.Text,
                Estado = txtEstado.Text,
                SocioId = (int)cboSocio.SelectedValue
                

            };
            context.membresias.Add(membresia);
            context.SaveChanges();
            this.Close();
        }
    }
}
