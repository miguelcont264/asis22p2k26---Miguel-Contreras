using CapaControlador_Seguridad;
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

namespace CapaVista_Seguridad.Reporte
{
    public partial class Form1 : Form
    {

        private ClsModeloModulo Seguridad1 = new ClsModeloModulo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport(); ReportDataSource reportDataSource = new ReportDataSource("Dseguridad", Seguridad1.SeguridadMetObtenerModulosReporte());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reporte.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}