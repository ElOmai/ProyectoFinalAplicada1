using ProyectoAplicadaI.Entidades;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class ReportedeCobros : Form
    {
        List<Cobros> datos = new List<Cobros>();
        public ReportedeCobros(List<Cobros> list)
        {
            InitializeComponent();
            datos = list;
        }

        

        private void CobrosViewer_Load(object sender, EventArgs e)
        {
            Cobrosreport abrir = new Cobrosreport();
            abrir.SetDataSource(datos);
            CobrosViewer.ReportSource = abrir;
            CobrosViewer.Refresh();

        }
    }
}
