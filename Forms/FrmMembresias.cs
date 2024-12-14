using ClubConnect.Data;
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
    public partial class FrmMembresias : Form
    {
        ClubConnectContext context = new ClubConnectContext();
        public FrmMembresias()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ClubConnectContext context = new ClubConnectContext();
            if (txtBuscar.Text.Trim().Length > 0)
            {
                dataGridMembresia.DataSource = context.membresias.Where(m => m.TipoDeMembresia.Contains(txtBuscar.Text.Trim())).Include(s => s.Socio).ToList();
            }
            else
            {
                dataGridMembresia.DataSource = context.membresias.Include(s => s.Socio).ToList();
            }
            dataGridMembresia.Columns[5].Visible = false;
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
            int idAEliminar = (int)dataGridMembresia.CurrentRow.Cells[0].Value;
            string membresiaAEliminar = (string)dataGridMembresia.CurrentRow.Cells[1].Value;

            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar a la membresía {membresiaAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new ClubConnectContext();
                    var membresia = context.membresias.Find(idAEliminar);
                    context.membresias.Remove(membresia);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar a la membresía {membresiaAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaMembresia frmNuevaMembresia = new FrmNuevaMembresia();
            frmNuevaMembresia.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridMembresia.CurrentRow.Cells[0].Value;

            FrmEditarMembresia frmEditarMembresia = new FrmEditarMembresia(idAEditar);
            frmEditarMembresia.ShowDialog();
            CargarGrilla();
        }
    }
}
