using ProyectoAplicadaI.Entidades;
using System;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Registros
{
    public partial class RegistrodeClientes : Form
    {
        public RegistrodeClientes()
        {
            InitializeComponent();
        }

        private void RegistrodeClientes_Load(object sender, EventArgs e)
        {

        }

        private bool Validar(int error)
        {
            bool errores = false;
            if (error == 1 && clienteIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(clienteIdNumericUpDown, "Introduzca el ID Del cliente");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                GeneralerrorProvider.SetError(direccionTextBox, "Introduzca la direccion del cliente");
                errores = true;
            }
            
            if(error ==2 && cedulaMaskedTextBox.MaskFull == false)
            {

               GeneralerrorProvider.SetError(cedulaMaskedTextBox, "Completar los campos");

               errores = true;

            }

            if (error == 2 && telefonoMaskedTextBox.MaskFull == false)
            {

                GeneralerrorProvider.SetError(telefonoMaskedTextBox, "Completar los campos");

                errores = true;

            }

            if (error == 2 && string.IsNullOrWhiteSpace(cedulaMaskedTextBox.Text))
            {
                GeneralerrorProvider.SetError(cedulaMaskedTextBox, "Complete cedula");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(telefonoMaskedTextBox.Text))
            {
                GeneralerrorProvider.SetError(telefonoMaskedTextBox, "Complete telefono");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(nombreTextBox.Text))
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Complete nombre");
                errores = true;
            }
            if (error == 3 && int.TryParse(nombreTextBox.Text, out int num) == true)
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Introduzca letras");
                errores = true;
            }


            return errores;

        }

        private void Limpiar()
        {
            clienteIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
            cedulaMaskedTextBox.Clear();
            direccionTextBox.Clear();
            telefonoMaskedTextBox.Clear();

            GeneralerrorProvider.Clear();
        }

        private Clientes Llenaclase()
        {
            Clientes clientes = new Clientes
            {
                ClienteId = Convert.ToInt32(clienteIdNumericUpDown.Value),
                Nombre = nombreTextBox.Text,
                Cedula = cedulaMaskedTextBox.Text,
                Direccion = direccionTextBox.Text,
                Telefono = telefonoMaskedTextBox.Text
            };

            return clientes;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Clientes clientes = Llenaclase();
            int id = Convert.ToInt32(clienteIdNumericUpDown.Value);

            if (Validar(3))
            {
                MessageBox.Show("Favor introduzca un nombre","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (Validar(2))
            {
                MessageBox.Show("Favor de llenar las casillas correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (clienteIdNumericUpDown.Value == 0)
                {
                    paso = BLL.ClienteBLL.Guardar(clientes);
                }
                else
                {

                    var cliente = BLL.ClienteBLL.Buscar(id);

                    if (cliente != null)
                    {
                        paso = BLL.ClienteBLL.Modificar(clientes);
                    }
                    else
                    {
                        MessageBox.Show("Id no existe", "Falló",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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

            private void Buscarbutton_Click(object sender, EventArgs e)
            {
                if (Validar(1))
                {
                    MessageBox.Show("Introduzca un ID para poder Buscar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                {
                    int id = Convert.ToInt32(clienteIdNumericUpDown.Value);
                    Clientes clientes = BLL.ClienteBLL.Buscar(id);

                    if (clientes != null)
                    {
                       clienteIdNumericUpDown.Value = clientes.ClienteId;
                        nombreTextBox.Text = clientes.Nombre;
                        cedulaMaskedTextBox.Text = clientes.Cedula;
                        direccionTextBox.Text = clientes.Direccion;
                        telefonoMaskedTextBox.Text = clientes.Telefono;

                    }
                    else
                    {
                        MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GeneralerrorProvider.Clear();
                }
            }

            private void Eliminarbutton_Click(object sender, EventArgs e)
            {
                if (Validar(1))
                {
                    MessageBox.Show("Favor de Llenar casilla para poder Eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                {
                    int id = Convert.ToInt32(clienteIdNumericUpDown.Value);

                    if (BLL.ClienteBLL.Eliminar(id))
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

            private void Nuevobutton_Click(object sender, EventArgs e)
            {
                 Limpiar();
            }

       
    }   }
