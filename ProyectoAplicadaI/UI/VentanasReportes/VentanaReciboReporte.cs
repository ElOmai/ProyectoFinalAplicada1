using ProyectoAplicadaI.Entidades;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class VentanaReciboReporte : Form
    {
        List<Empeños> datos = new List<Empeños>();
   

        public VentanaReciboReporte(List<Empeños> list)
        {
            InitializeComponent();
            datos = list;
        }

      

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteRecibo abrir = new ReporteRecibo();
            abrir.SetDataSource(datos);
            ReciboViewer.ReportSource = abrir;
            ReciboViewer.Refresh();
        }
    }
}
