using ClubConnect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubConnect.ViewForms
{
    public partial class ReservasViewForms : Form
    {
        ReportViewer reporte = new ReportViewer();
        ClubConnectContext context = new ClubConnectContext();
        public ReservasViewForms()
        {
            InitializeComponent();

            //Para que el reporte ocupe todo el formulario
            reporte.Dock = DockStyle.Fill;

            //Establece la vista de impresion
            reporte.SetDisplayMode(DisplayMode.PrintLayout);

            //Establece el zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            Controls.Add(reporte);
        }

        private void ReservasViewForms_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ClubConnect.Reportes.ReservasReport.rdlc";
            var reservas = context.reservas.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSReservas", reservas));

            reporte.RefreshReport();
        }
    }
}
