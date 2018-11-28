using ProyectoAplicadaI.Entidades;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class VentanadeListadeEmpeños : Form
    {
        List<Empeños> datos = new List<Empeños>();
        public VentanadeListadeEmpeños(List<Empeños> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void VentanadeLista_de_Recibo_Load(object sender, EventArgs e)
        {

        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadeRecibosdeEmpeño abrir = new ListadeRecibosdeEmpeño();
            abrir.SetDataSource(datos);
            ReciboViewer.ReportSource = abrir;
            ReciboViewer.Refresh();
        }
    }
}
