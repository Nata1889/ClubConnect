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
    public partial class FrmNuevaReserva : Form
    {
        ClubConnectContext context = new ClubConnectContext();
        public FrmNuevaReserva()
        {
            InitializeComponent();
            CargarCboSocios();
            CargarCboInstalaciones();
        }

        private void CargarCboSocios()
        {
            cboSocio.DataSource = context.socios.ToList();
            cboSocio.DisplayMember = "Nombre";
            cboSocio.ValueMember = "Id";
        }
        private void CargarCboInstalaciones()
        {
            cboInstalacion.DataSource = context.instalaciones.ToList();
            cboInstalacion.DisplayMember = "Nombre";
            cboInstalacion.ValueMember = "Id";
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClubConnectContext context = new ClubConnectContext();
            var reserva = new Reserva()
            {
                FechaYHoraDeInicio = txtFechaDeInicio.Text,
                FechaYHoraDeFin = txtFechaDeFin.Text,
                //Estado = txtEstado.Text,
                Estado = EstadoReserva.Confirmada,
                SocioId = (int)cboSocio.SelectedValue,
                InstalacionId = (int)cboInstalacion.SelectedValue
            };
            context.reservas.Add(reserva);
            context.SaveChanges();
            this.Close();
        }
    }
}
