using ProyectoAplicadaI.BLL;
using ProyectoAplicadaI.UI.VentanasReportes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProyectoAplicadaI.Entidades;

namespace ProyectoAplicadaI.UI.Registros
{
    public partial class RegistrodeEmpeño : Form
    {
        public RegistrodeEmpeño()
        {
            InitializeComponent();
            LlenaCombobox();
            nombrelabel.Text = $"{ UsuariosBLL.ReturnUsuario().TipodeUsuario}: {UsuariosBLL.ReturnUsuario().Nombre }";
        }

        private int ToInt(object valor)
        {
            int.TryParse(valor.ToString(), out int retorno);
            return retorno;
        }

        private decimal ToDecimal(object valor)
        {
            decimal.TryParse(valor.ToString(), out decimal retorno);
            return retorno;
        }

        private bool Validar(int error)
        {
            bool paso = false;
            if (error == 1 && reciboIdNumericUpDown.Value == 0)
            {
                HayErrores.SetError(reciboIdNumericUpDown,
                   "No debes dejar la Recibo Id Vacio");
                paso = true;
            }
            if (error == 2 && DetalledataGridView.RowCount == 0)
            {
                HayErrores.SetError(DetalledataGridView,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            if (error == 4 && string.IsNullOrWhiteSpace(montoTextBox.Text))
            {
                HayErrores.SetError(montoTextBox,
                   "No debes dejar la Monto vacio");
                paso = true;
            }
            if (error == 4 && string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                HayErrores.SetError(descripcionTextBox,
                   "No debes dejar la descripcion vacia");
                paso = true;
            }
            if (error == 4 && cantidadNumericUpDown.Value == 0)
            {
                HayErrores.SetError(cantidadNumericUpDown,
                   "No debes dejar la Cantidad vacia");
                paso = true;
            }
            if (error == 3 && decimal.TryParse(montoTextBox.Text, out decimal num) == false)
            {
                HayErrores.SetError(montoTextBox,
                   "Debe Dijitar un Monto");
                paso = true;
            }
            if (error == 5 && string.IsNullOrWhiteSpace(clienteIdComboBox.Text) || string.IsNullOrEmpty(articuloIdComboBox.Text))
            {
                HayErrores.SetError(clienteIdComboBox,
                   "No hay Cliente o Articulos Creado");
                paso = true;
            }
            if (error == 5 && string.IsNullOrEmpty(articuloIdComboBox.Text))
            {
                HayErrores.SetError(articuloIdComboBox,
                   "No hay Cliente o Articulos Creado");
                paso = true;
            }
            return paso;
        }

        public void SinColumnas()
        {
            DetalledataGridView.Columns["ID"].Visible = false;
            DetalledataGridView.Columns["EmpeñoId"].Visible = false;
            DetalledataGridView.Columns["ArticuloId"].Visible = false;
            DetalledataGridView.Columns["articulos"].Visible = false;
        }

        private void LlenaCombobox()
        {
            RepositorioBase<Clientes> clientes = new RepositorioBase<Clientes>(new Contexto());
            clienteIdComboBox.DataSource = clientes.GetList(c => true);
            clienteIdComboBox.ValueMember = "ClienteId";
            clienteIdComboBox.DisplayMember = "Nombre";
            RepositorioBase<Articulos> articulos = new RepositorioBase<Articulos>(new Contexto());
            articuloIdComboBox.DataSource = articulos.GetList(c => true);
            articuloIdComboBox.ValueMember = "ArticuloId";
            articuloIdComboBox.DisplayMember = "Nombre";
        }


        public void Limpiar()
        {
            reciboIdNumericUpDown.Value = 0;
            fechadeEmpeñoDateTimePicker.Value = DateTime.Now;
            fechaActualDateTimePicker.Value = DateTime.Now;
            cantidadNumericUpDown.Value = 0;
            descripcionTextBox.Clear();
            montoTextBox.Clear();
            montoTotalTextBox.Clear();
            DetalledataGridView.DataSource = null;
            HayErrores.Clear();
        }

        public void LimpiaRecibo()
        {
            fechadeEmpeñoDateTimePicker.Value = DateTime.Now;
            fechaActualDateTimePicker.Value = DateTime.Now;
            cantidadNumericUpDown.Value = 0;
            descripcionTextBox.Clear();
            montoTextBox.Clear();
            HayErrores.Clear();
        }
        


        private Empeños LlenaClase()
        {
            Empeños recibo = new Empeños
            {
                EmpeñoId = Convert.ToInt32(reciboIdNumericUpDown.Value),
                ClienteId = Convert.ToInt32(clienteIdComboBox.SelectedValue),
                NombredeCliente = BLL.ClienteBLL.RetornarNombre(clienteIdComboBox.Text),
                Fecha = fechadeEmpeñoDateTimePicker.Value,
                MontoTotal = Convert.ToDecimal(montoTotalTextBox.Text),
                Abono = 0,
                UltimaFechadeVigencia = fechadeEmpeñoDateTimePicker.Value.AddDays(95)
            };

            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {

                recibo.AgregarDetalle
                (ToInt(item.Cells["iD"].Value),
                recibo.EmpeñoId,
                ToInt(item.Cells["articuloId"].Value), 
                Convert.ToString(item.Cells["articulo"].Value),
                Convert.ToString(item.Cells["descripcion"].Value),
                ToInt(item.Cells["cantidad"].Value),
                ToDecimal(item.Cells["monto"].Value)
                  );
            }
            return recibo;
        }

        private void LlenaCampos(Empeños recibos)
        {

            reciboIdNumericUpDown.Value = recibos.EmpeñoId;
            fechadeEmpeñoDateTimePicker.Value = recibos.Fecha;
            clienteIdComboBox.Text = recibos.NombredeCliente;
            montoTotalTextBox.Text = recibos.MontoTotal.ToString();
            DetalledataGridView.DataSource = recibos.Detalle;
            SinColumnas();
        }

        private void RegistrodeRecibo_Load(object sender, EventArgs e)
        {
            DateTime FechaAct = fechaActualDateTimePicker.Value;
            DateTime FechaEmpeño = fechadeEmpeñoDateTimePicker.Value.AddDays(90);
            if (FechaAct >= FechaEmpeño)
            {
                estadolabel.Text = "Vencido";
                estadolabel.ForeColor = Color.Red;
            }
            else
            {
                estadolabel.Text = "Vigente";
                estadolabel.ForeColor = Color.Green;
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if(Validar(5))
            {
                MessageBox.Show(" ComboBox Vacio", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Validar(4))
            {
                MessageBox.Show(" LLene las Casillas Correspondiente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            if (Validar(3))
            {
                MessageBox.Show(" Digite un Monto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                HayErrores.Clear();
                List<EmpeñosDetalle> detalle = new List<EmpeñosDetalle>();
                if (DetalledataGridView.DataSource != null)
                {
                    detalle = (List<EmpeñosDetalle>)DetalledataGridView.DataSource;
                }

                if (string.IsNullOrEmpty(montoTextBox.Text) && string.IsNullOrEmpty(cantidadNumericUpDown.Text))
                {
                    MessageBox.Show("Llene cantidad y Monto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    detalle.Add(
                        new EmpeñosDetalle(Id: 0,
                        reciboId: (int)Convert.ToInt32(reciboIdNumericUpDown.Value),
                        articuloId: (int)articuloIdComboBox.SelectedValue,
                        articulo: (string)BLL.ArticulosBLL.RetornarNombre(articuloIdComboBox.Text),
                        descripcion: (string)descripcionTextBox.Text,
                        cantidad: (int)Convert.ToInt32(cantidadNumericUpDown.Value),
                        monto: (decimal)Convert.ToDecimal(montoTextBox.Text)

                        ));
                    DetalledataGridView.DataSource = null;
                    DetalledataGridView.DataSource = detalle;
                    decimal monto = 0;
                    foreach (var item in detalle)
                    {
                        monto += item.Monto;
                    }
                    montoTotalTextBox.Text = monto.ToString();
                    SinColumnas();
                    LimpiaRecibo();
                }
            }
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
           EmpeñosDetalle recibo = new EmpeñosDetalle();
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                List<EmpeñosDetalle> detalle = (List<EmpeñosDetalle>)DetalledataGridView.DataSource;
                detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                decimal monto = 0;
                foreach (var item in detalle)
                {
                    monto -= item.Monto;
                }
                monto *= (-1);
                montoTotalTextBox.Text = monto.ToString();
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = detalle;
                SinColumnas();
            }
        }
        private void FechadeEmpeñoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaAct = fechaActualDateTimePicker.Value;
            DateTime FechaEmpeño = fechadeEmpeñoDateTimePicker.Value.AddDays(95);
            if (FechaAct >= FechaEmpeño)
            {
                estadolabel.Text = "Vencido";
                estadolabel.ForeColor = Color.Red;
            }
            else
            {
                estadolabel.Text = "Vigente";
                estadolabel.ForeColor = Color.Green;
            }
        }
        private void FechaActualDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaAct = fechaActualDateTimePicker.Value;
            DateTime FechaEmpeño = fechadeEmpeñoDateTimePicker.Value.AddDays(90);
            if (FechaAct >= FechaEmpeño)
            {
                estadolabel.Text = "Vencido";
                estadolabel.ForeColor = Color.Red;
            }
            else
            {
                estadolabel.Text = "Vigente";
                estadolabel.ForeColor = Color.Green;
            }
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (Validar(2))
            {
                MessageBox.Show("Debe Agregar Algun Articulo al Grid", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Empeños recibos = LlenaClase();
                bool Paso = false;
                if (reciboIdNumericUpDown.Value == 0)
                {
                    Paso = EmpeñosBLL.Guardar(recibos);
                    HayErrores.Clear();
                }
                else
                {
                    var V = EmpeñosBLL.Buscar(Convert.ToInt32(reciboIdNumericUpDown.Value));
                    if (V != null)
                    {
                        Paso = EmpeñosBLL.Modificar(recibos);
                    }
                    HayErrores.Clear();
                }
                if (MessageBox.Show("¿Desea Imprimir el Recibo?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    List<Empeños> list = EmpeñosBLL.GetList(X => true);
                    List<Empeños> nuevo = new List<Empeños>
                    {
                        list.Last()
                    };
                    VentanaReciboReporte abrir = new VentanaReciboReporte(nuevo);
                    abrir.Show();
                }
                if (Paso)
                {
                    
                    MessageBox.Show("Guardado!!", "Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor Llenar Casilla!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(reciboIdNumericUpDown.Value);
                if (EmpeñosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(reciboIdNumericUpDown.Value);
            Empeños recibos = EmpeñosBLL.Buscar(id);
            if (recibos != null)
            {
                LlenaCampos(recibos);
                if (MessageBox.Show("¿Desea Imprimir el Recibo?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (var item in  EmpeñosBLL.GetList(X => true))
                    {
                        if(item.EmpeñoId == reciboIdNumericUpDown.Value)
                        {
                            VentanaReciboReporte abrir = new VentanaReciboReporte(EmpeñosBLL.GetList(X => X.EmpeñoId == item.EmpeñoId));
                            abrir.Show();

                        }
                    }
                }
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
