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
    public partial class FrmNuevoEvento : Form
    {
        public FrmNuevoEvento()
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
            var evento = new Evento()
            {
                NombreDelEvento = txtNombreDelEvento.Text,
                Descripcion = txtDescripcion.Text,
                FechaYhoraDelEvento = txtFechaYHoraDelEvento.Text,
                LugarDelEvento = txtLugarDelEvento.Text,
            };
            context.eventos.Add(evento);
            context.SaveChanges();
            this.Close();
        }
    }
}
