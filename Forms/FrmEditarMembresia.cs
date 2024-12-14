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
    public partial class FrmEditarMembresia : Form
    {
        ClubConnectContext context = new ClubConnectContext();

        int idMembresiaEditada;
        Membresia? membresia;

        public FrmEditarMembresia()
        {
            InitializeComponent();
            CargarDatosEnPantalla();
            CargarComboSocio();
        }

        
        private void CargarComboSocio()
        {
            cboSocio.DataSource = context.socios.ToList();
            cboSocio.DisplayMember = "Nombre";
            cboSocio.ValueMember = "Id";
        }

        public FrmEditarMembresia(int idMembresiaEditar)
        {
            InitializeComponent();
            this.idMembresiaEditada = idMembresiaEditar;
            CargarDatosEnPantalla();
            CargarComboSocio();
        }


        private void CargarDatosEnPantalla()
        {
            ClubConnectContext context = new ClubConnectContext();
            membresia = context.membresias.Find(idMembresiaEditada);
            if (membresia != null)
            {
                cboSocio.DataSource = context.socios.ToList();
                txtTipoDeMembresia.Text = membresia.TipoDeMembresia;
                txtFechaDeInicio.Text = membresia.FechaDeInicio;
                txtFechaDeExpiracion.Text = membresia.FechaDeExpiracion;
                txtEstado.Text = membresia.Estado;
                cboSocio.Text = membresia.Socio.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClubConnectContext context = new ClubConnectContext();
            membresia.TipoDeMembresia = txtTipoDeMembresia.Text;
            membresia.FechaDeInicio = txtFechaDeInicio.Text;
            membresia.FechaDeExpiracion = txtFechaDeExpiracion.Text;
            membresia.Estado = txtEstado.Text;
            membresia.SocioId = (int)cboSocio.SelectedValue;

            context.Entry(membresia).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }
    }
}
