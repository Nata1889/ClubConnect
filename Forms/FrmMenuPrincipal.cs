using ClubConnect.Forms;
using ClubConnect.ViewForms;

namespace ClubConnect
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void administrarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSocios frmSocios = new FrmSocios();
            frmSocios.ShowDialog();
        }

        private void administrarMembresíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMembresias frmMembresias = new FrmMembresias();
            frmMembresias.ShowDialog();
        }

        private void administrarInstalacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInstalacion frmInstalacion = new FrmInstalacion();
            frmInstalacion.ShowDialog();
        }

        private void administarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEventos frmEventos = new FrmEventos();
            frmEventos.ShowDialog();
        }

        private void administarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservas frmReservas = new FrmReservas();
            frmReservas.ShowDialog();
        }

        private void listadoDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SociosViewForms sociosViewForms = new SociosViewForms();
            sociosViewForms.ShowDialog();
        }

        private void listadoDeMembresíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembresiasViewForms membresiasViewForms = new MembresiasViewForms();
            membresiasViewForms.ShowDialog();
        }

        private void listadoDeInstalacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstalacionesViewForms instalacionesViewForms = new InstalacionesViewForms();
            instalacionesViewForms.ShowDialog();
        }

        private void listadoDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasViewForms reservasViewForms = new ReservasViewForms();
            reservasViewForms.ShowDialog();
        }

        private void listadoDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventosViewForms eventosViewForms = new EventosViewForms();
            eventosViewForms.ShowDialog();
        }
    }
}