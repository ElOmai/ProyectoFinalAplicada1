using ProyectoAplicadaI.BLL;
using ProyectoAplicadaI.UI.Cobro;
using ProyectoAplicadaI.UI.Consultas;
using ProyectoAplicadaI.UI.Registros;
using System;
using System.Windows.Forms;

namespace ProyectoAplicadaI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            usuarioToolStripMenuItem1.Text = UsuariosBLL.ReturnUsuario().Nombre;
            tipoDeUsuarioToolStripMenuItem.Text = UsuariosBLL.ReturnUsuario().TipodeUsuario;
        }
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeClientes clientes = new RegistrodeClientes();
            clientes.Show();
        }
        private void ArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeArticulos articulos = new RegistrodeArticulos();
            articulos.Show();
        }
        private void ReciboDeEmpeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeEmpeño recibo = new RegistrodeEmpeño();
            
            recibo.Show();
        }
        private void RegistrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeUsuarios usuarios = new RegistrodeUsuarios();
            if (UsuariosBLL.ReturnUsuario().TipodeUsuario == "Administrador")
                usuarios.Show();
            else
                MessageBox.Show("Solo los administradores pueden registrar usuarios", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
              
            }
        }
        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeClientes clientes = new ConsultadeClientes();
            clientes.Show();
        }
        private void ArticulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultadeArticulos articulos = new ConsultadeArticulos();
            articulos.Show();
        }
        private void EmpeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeArticulosEmpeñados recibos = new ConsultadeArticulosEmpeñados();
            recibos.Show();
        }
        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeUsuarios usuarios = new ConsultadeUsuarios();
           if (UsuariosBLL.ReturnUsuario().TipodeUsuario == "Administrador")
                usuarios.Show();
            else
                MessageBox.Show("Solo los administradores pueden consultar usuarios", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void RecibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeRecibos recibos = new ConsultadeRecibos();
            recibos.Show();
        }
        private void PagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadePagos consulta = new ConsultadePagos();
            consulta.Show();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void CobrosDeArticulosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistrodePago cobros = new RegistrodePago();
            cobros.Show();
        }
        private void AyudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por Luis Omar Emilio Pérez Rodríguez 2015-0954", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
