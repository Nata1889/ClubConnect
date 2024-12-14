using ClubConnect.Data;
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
    public partial class FrmEventos : Form
    {
        ClubConnectContext context = new ClubConnectContext();
        public FrmEventos()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ClubConnectContext context = new ClubConnectContext();
            if (txtBuscar.Text.Trim().Length > 0)
            {
                dataGridEventos.DataSource = context.eventos.Where(e => e.NombreDelEvento.Contains(txtBuscar.Text.Trim())).ToList();
            }
            else
            {
                dataGridEventos.DataSource = context.eventos.ToList();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridEventos.CurrentRow.Cells[0].Value;
            string eventoAEliminar = (string)dataGridEventos.CurrentRow.Cells[1].Value;

            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar el evento {eventoAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new ClubConnectContext();
                    var evento = context.eventos.Find(idAEliminar);
                    context.eventos.Remove(evento);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar al evento {eventoAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEvento frmNuevoEvento = new FrmNuevoEvento();
            frmNuevoEvento.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idEventoEditar = (int)dataGridEventos.CurrentRow.Cells[0].Value;

            FrmEditarEvento frmEditarEvento = new FrmEditarEvento(idEventoEditar);
            frmEditarEvento.ShowDialog();
            CargarGrilla();
        }
    }
}
