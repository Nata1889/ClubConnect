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
    public partial class FrmSocios : Form
    {
        ClubConnectContext context = new ClubConnectContext();
        public FrmSocios()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ClubConnectContext context = new ClubConnectContext();
            if (txtBuscar.Text.Trim().Length > 0)
            {
                dataGridSocios.DataSource = context.socios.Where(s => s.Nombre.Contains(txtBuscar.Text.Trim()) || s.Apellido.Contains(txtBuscar.Text.Trim())).ToList();
            }
            else
            {
                dataGridSocios.DataSource = context.socios.ToList();
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
            int idAEliminar = (int)dataGridSocios.CurrentRow.Cells[0].Value;
            string socioAEliminar = (string)dataGridSocios.CurrentRow.Cells[1].Value;

            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar al socio {socioAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new ClubConnectContext();
                    var socio = context.socios.Find(idAEliminar);
                    context.socios.Remove(socio);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar al socio {socioAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoSocio frmNuevoSocio = new FrmNuevoSocio();
            frmNuevoSocio.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridSocios.CurrentRow.Cells[0].Value;

            FrmEditarSocio frmEditarSocio = new FrmEditarSocio(idAEditar);
            frmEditarSocio.ShowDialog();
            CargarGrilla();
        }
    }
}
