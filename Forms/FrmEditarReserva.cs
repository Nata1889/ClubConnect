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
    public partial class FrmEditarReserva : Form
    {
        ClubConnectContext context = new ClubConnectContext();

        int idReservaEditada;
        Reserva? reserva;

        public FrmEditarReserva()
        {
            InitializeComponent();
            CargarDatosEnPantalla();
            CargarCboSocio();
            CargarCboInstalacion();
            CargarCboEstado();
        }

        private void CargarCboEstado()
        {
            cboEstado.Items.Add(EstadoReserva.Pendiente);
            cboEstado.Items.Add(EstadoReserva.Confirmada);
            cboEstado.Items.Add(EstadoReserva.Cancelada);
        }

        private void CargarCboSocio()
        {
            cboSocio.DataSource = context.socios.ToList();
            cboSocio.DisplayMember = "Nombre";
            cboSocio.ValueMember = "Id";
        }
        private void CargarCboInstalacion()
        {
            cboInstalacion.DataSource = context.instalaciones.ToList();
            cboInstalacion.DisplayMember = "Nombre";
            cboInstalacion.ValueMember = "Id";
        }

        

        public FrmEditarReserva(int reservaAEditar)
        {
            InitializeComponent();
            this.idReservaEditada = reservaAEditar;
            CargarDatosEnPantalla();
            CargarCboSocio();
            CargarCboInstalacion();
            CargarCboEstado();
        }

        private void CargarDatosEnPantalla()
        {
            ClubConnectContext context = new ClubConnectContext();
            reserva = context.reservas.Find(idReservaEditada);

            if (reserva != null)
            {
                cboSocio.DataSource = context.socios.ToList();
                cboInstalacion.DataSource = context.instalaciones.ToList();
                txtFechaDeInicio.Text = reserva.FechaYHoraDeInicio;
                txtFechaDeFin.Text = reserva.FechaYHoraDeFin;
                cboEstado.Text = reserva.Estado.ToString();
                cboSocio.Text = reserva.Socio.ToString();
                cboInstalacion.Text = reserva.Instalacion.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClubConnectContext context = new ClubConnectContext();
            reserva.FechaYHoraDeInicio = txtFechaDeInicio.Text;
            reserva.FechaYHoraDeFin = txtFechaDeFin.Text;
            //reserva.Estado = txtEstado.Text;
            reserva.Estado = (EstadoReserva)Enum.Parse(typeof(EstadoReserva), cboEstado.Text);
            reserva.SocioId = (int)cboSocio.SelectedValue;
            reserva.InstalacionId = (int)cboInstalacion.SelectedValue;

            context.Entry(reserva).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }
    }
}
