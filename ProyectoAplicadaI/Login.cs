using ProyectoAplicadaI.BLL;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using ProyectoAplicadaI.Entidades;

namespace ProyectoAplicadaI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Accederbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> usuarios = new RepositorioBase<Usuarios>(new Contexto());
          
            var Lista = usuarios.GetList(x => x.Usuario.Equals(UsuariotextBox.Text) && x.Contraseña.Equals(ClavetextBox.Text));
            Usuarios usuario = (Lista != null && Lista.Count > 0) ? Lista[0] : null;

            if (usuario != null)
            {
                foreach (var item in UsuariosBLL.GetList(x => x.Usuario == UsuariotextBox.Text))
                {
                    UsuariosBLL.NombreLogin(item.Nombre,item.TipodeUsuario);
                }
                this.Hide();
                Thread hilo = new Thread(InterfazUsuario);
                hilo.Start();

                return;
            }
            else
            {
                MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClavetextBox.Clear();
            }

        }

        private void InterfazUsuario()
        {
            DataTable dt =new DataTable();
            Application.Run(new MainForm());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
