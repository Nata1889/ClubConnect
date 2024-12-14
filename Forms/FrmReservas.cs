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
    public partial class FrmReservas : Form
    {
        ClubConnectContext context = new ClubConnectContext();
        public FrmReservas()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ClubConnectContext context = new ClubConnectContext();

            if (txtBuscar.Text.Trim().Length > 0)
            {
                dataGridReservas.DataSource = context.reservas.Where(e => e.Estado.ToString().Contains(txtBuscar.Text.Trim())).Include(r => r.Socio).Include(r=>r.Instalacion).ToList();
            }
            else
            {
                dataGridReservas.DataSource = context.reservas.Include(r => r.Socio).Include(r => r.Instalacion).ToList();
            }
            dataGridReservas.Columns[4].Visible = false;
            dataGridReservas.Columns[6].Visible = false;
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
            int idAEliminar = (int)dataGridReservas.CurrentRow.Cells[0].Value;
            string reservaAEliminar = (string)dataGridReservas.CurrentRow.Cells[1].Value;

            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar la reserva del {reservaAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new ClubConnectContext();
                    var reserva = context.reservas.Find(idAEliminar);
                    context.reservas.Remove(reserva);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar la reserva del  {reservaAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaReserva frmNuevaReserva = new FrmNuevaReserva();
            frmNuevaReserva.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridReservas.CurrentRow.Cells[0].Value;

            FrmEditarReserva frmEditarReserva = new FrmEditarReserva(idAEditar);
            frmEditarReserva.ShowDialog();
            CargarGrilla();
        }
    }
}
