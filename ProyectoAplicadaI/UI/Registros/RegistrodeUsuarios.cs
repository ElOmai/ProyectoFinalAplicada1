using ProyectoAplicadaI.Entidades;
using System;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Registros
{
    public partial class RegistrodeUsuarios : Form
    {
        public RegistrodeUsuarios()
        {
            InitializeComponent();
        }

        private bool Validar(int error)
        {
            bool errores = false;
            if (error == 1 && usuariosIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(usuariosIdNumericUpDown, "Llenar Usuario Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Llene Nombre");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(usuarioTextBox.Text))
            {
                GeneralerrorProvider.SetError(usuarioTextBox, "Llene Usuario");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(contraseñaTextBox.Text))
            {
                GeneralerrorProvider.SetError(contraseñaTextBox, "Llene contraseña");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(ConfirmartextBox.Text))
            {
                GeneralerrorProvider.SetError(ConfirmartextBox, "Llene contraseña");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(tipodeusuarioComboBox.Text))
            {
                GeneralerrorProvider.SetError(tipodeusuarioComboBox, "Llene Tipo de Usuario");
                errores = true;
            }
            if (error == 3 && int.TryParse(nombreTextBox.Text, out int num) == true)
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Debe Digitar Caracteres");
                errores = true;
            }

            if (error == 4 && contraseñaTextBox.Text != ConfirmartextBox.Text)
            {
                GeneralerrorProvider.SetError(ConfirmartextBox, "Llenar Confirmar Contraseña");
                errores = true;
            }


            return errores;

        }

        private void Limpiar()
        {
            usuariosIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
            usuarioTextBox.Clear();
            contraseñaTextBox.Clear();
            ConfirmartextBox.Clear();
            tipodeusuarioComboBox.SelectedItem = null;

            GeneralerrorProvider.Clear();
        }

        private Usuarios Llenaclase()
        {
            Usuarios usuarios = new Usuarios
            {
                UsuariosId = Convert.ToInt32(usuariosIdNumericUpDown.Value),
                Nombre = nombreTextBox.Text,
                Usuario = usuarioTextBox.Text,
                Contraseña = contraseñaTextBox.Text,
                TipodeUsuario = tipodeusuarioComboBox.Text
            };

            return usuarios;
        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar","Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);
                Usuarios usuarios = BLL.UsuariosBLL.Buscar(id);

                if (usuarios != null)
                {
                    usuariosIdNumericUpDown.Value = usuarios.UsuariosId;
                    nombreTextBox.Text = usuarios.Nombre;
                    usuarioTextBox.Text = usuarios.Usuario;
                    contraseñaTextBox.Text = usuarios.Contraseña;
                    tipodeusuarioComboBox.Text = usuarios.TipodeUsuario;

                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }
        }

        private void RegistrodeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar","Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);

                if (BLL.UsuariosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Usuarios usuarios = Llenaclase();
            int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);

           

            if (Validar(3))
            {
                MessageBox.Show("Favor Dijite un Nombre","Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Validar(4))
            {
                MessageBox.Show("La Contraseña no son Iguales","Validacion",MessageBoxButtons.OK, MessageBoxIcon.Error);
                contraseñaTextBox.Clear();
                ConfirmartextBox.Clear();
                return;
            }

            if (Validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (usuariosIdNumericUpDown.Value == 0)
                {
                    paso = BLL.UsuariosBLL.Guardar(usuarios);
                }
                else
                {

                    var usuario = BLL.UsuariosBLL.Buscar(id);

                    if (usuario != null)
                    {
                        paso = BLL.UsuariosBLL.Modificar(usuarios);
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Limpiar();
                GeneralerrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
