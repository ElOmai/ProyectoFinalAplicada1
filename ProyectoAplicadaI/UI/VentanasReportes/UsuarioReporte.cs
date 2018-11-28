using ProyectoAplicadaI.Entidades;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class UsuarioReporte : Form
    {
        List<Usuarios> datos = new List<Usuarios>();
        public UsuarioReporte(List<Usuarios> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void UsuarioViewer_Load(object sender, EventArgs e)
        {
            ReporteUsuarios abrir = new ReporteUsuarios();
            abrir.SetDataSource(datos);
            UsuarioViewer.ReportSource = abrir;
            UsuarioViewer.Refresh();
         }
    }
}
