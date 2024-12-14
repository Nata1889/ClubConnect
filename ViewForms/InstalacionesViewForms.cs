using ClubConnect.Data;
using ClubConnect.Models;
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
    public partial class InstalacionesViewForms : Form
    {
        ReportViewer reporte = new ReportViewer();
        ClubConnectContext context = new ClubConnectContext();
        public InstalacionesViewForms()
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

        private void InstalacionesViewForms_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ClubConnect.Reportes.InstalacionesReport.rdlc";
            var instalaciones = context.instalaciones.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSInstalaciones", instalaciones));

            reporte.RefreshReport();
        }
    }
}
