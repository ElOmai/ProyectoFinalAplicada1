using ProyectoAplicadaI.Entidades;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class ClienteReporte : Form
    {
        List<Clientes> datos = new List<Clientes>();
        public ClienteReporte(List<Clientes> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void ClienteViewer_Load(object sender, EventArgs e)
        {
            RepoteClientes abrir = new RepoteClientes();
            abrir.SetDataSource(datos);
            ClienteViewer.ReportSource = abrir;
            ClienteViewer.Refresh();
        }
    }
}
