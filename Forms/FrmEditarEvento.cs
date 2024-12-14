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
    public partial class FrmEditarEvento : Form
    {
        int idEventoEditado;
        Evento? evento;
        public FrmEditarEvento(int idEventoEditar)
        {
            InitializeComponent();
            this.idEventoEditado = idEventoEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            ClubConnectContext context = new ClubConnectContext();
            evento = context.eventos.Find(idEventoEditado);

            if (evento != null)
            {
                txtNombreDelEvento.Text = evento.NombreDelEvento;
                txtDescripcion.Text = evento.Descripcion;
                txtFechaYHoraDelEvento.Text = evento.FechaYhoraDelEvento;
                txtLugarDelEvento.Text = evento.LugarDelEvento;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClubConnectContext context = new ClubConnectContext();

            evento.NombreDelEvento = txtNombreDelEvento.Text;
            evento.Descripcion = txtDescripcion.Text;
            evento.FechaYhoraDelEvento = txtFechaYHoraDelEvento.Text;
            evento.LugarDelEvento = txtLugarDelEvento.Text;

            context.Entry(evento).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }
    }
}
