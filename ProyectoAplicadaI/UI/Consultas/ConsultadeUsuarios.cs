using ProyectoAplicadaI.Entidades;
using ProyectoAplicadaI.UI.VentanasReportes;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Consultas
{
    public partial class ConsultadeUsuarios : Form
    {
        public ConsultadeUsuarios()
        {
            InitializeComponent();
        }
        Expression<Func<Usuarios, bool>> filtro = x => true;
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                        filtro = x => x.UsuariosId == id;

                        if (BLL.UsuariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este ID, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;
                case 1://Nombre

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar un Nombre!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        filtro = x => x.Nombre.Contains(CriteriotextBox.Text);


                        if (BLL.UsuariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Nombre, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 2://Usuario

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar la Cedula con sus Guiones!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        filtro = x => x.Usuario.Equals(CriteriotextBox.Text);

                        if (BLL.UsuariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Esta Cedula, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 3://Contraseña

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar el telefono con sus Guiones!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        filtro = x => x.Contraseña.Equals(CriteriotextBox.Text);


                        if (BLL.UsuariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Telefono, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 4://TipodeUsuario

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar una Direccion!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        filtro = x => x.TipodeUsuario.Equals(CriteriotextBox.Text);


                        if (BLL.UsuariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Esta Direccion, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 5://TODO
                    filtro = x => true;

                    if (BLL.UsuariosBLL.GetList(filtro).Count() == 0)
                    {
                        MessageBox.Show("Lista esta Vacia, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
            }

            if (FiltrocomboBox.SelectedItem != null)
            {
                UsuariodataGridView.DataSource = BLL.UsuariosBLL.GetList(filtro);
                CriteriotextBox.Clear();
                GeneralerrorProvider.Clear();
            }
        }

        private bool Validar(int error)
        {
            bool paso = false;
            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Por Favor, LLenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out int num) == false)
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Debe Digitar un Numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                paso = true;
            }

            return paso;
        }

        private void UsuariodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

            if (UsuariodataGridView.DataSource != null)
            {

                UsuarioReporte abrir = new UsuarioReporte(BLL.UsuariosBLL.GetList(filtro));
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Grid esta Vacio, No puede hacer se un Reporte ", "Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }

        private void ConsultadeUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
