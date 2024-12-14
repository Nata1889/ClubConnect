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
    public partial class FrmInstalacion : Form
    {
        ClubConnectContext context = new ClubConnectContext();
        public FrmInstalacion()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ClubConnectContext context = new ClubConnectContext();
            if (txtBuscar.Text.Trim().Length > 0)
            {
                dataGridInstalacion.DataSource = context.instalaciones.Where(i => i.NombreDeLaInstalacion.Contains(txtBuscar.Text.Trim()) || i.Descripcion.Contains(txtBuscar.Text.Trim())).ToList();
            }
            else
            {
                dataGridInstalacion.DataSource = context.instalaciones.ToList();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridInstalacion.CurrentRow.Cells[0].Value;
            string instalacionAEliminar = (string)dataGridInstalacion.CurrentRow.Cells[1].Value;

            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar a la instalación {instalacionAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new ClubConnectContext();
                    var instalacion = context.instalaciones.Find(idAEliminar);
                    context.instalaciones.Remove(instalacion);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar a la instalación{instalacionAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaInstalacion frmNuevaInstalacion = new FrmNuevaInstalacion();
            frmNuevaInstalacion.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridInstalacion.CurrentRow.Cells[0].Value;

            FrmEditarInstalacion frmEditarInstalacion = new FrmEditarInstalacion(idAEditar);
            frmEditarInstalacion.ShowDialog();
            CargarGrilla();
        }
    }
}
