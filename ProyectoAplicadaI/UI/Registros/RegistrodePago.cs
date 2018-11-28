using ProyectoAplicadaI.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Cobro
{
    public partial class RegistrodePago : Form
    {
        public RegistrodePago()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Empeños, bool>> filtro = x => true;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0: 
                    if (Validar(1))
                    {
                        MessageBox.Show("Introduzca ID ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Introduzca numeros", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.EmpeñoId == id && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.EmpeñoId == id;
                        }
                        if (BLL.EmpeñosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            return;
                        }
                    }
                    break;
            }
            if (FiltrocomboBox.SelectedItem != null)
            {
                CobrosdataGridView.DataSource = BLL.EmpeñosBLL.GetList(filtro);
                if (FiltrocomboBox.SelectedIndex == 0)
                {
                    foreach (var item in BLL.EmpeñosBLL.GetList(filtro))
                    {
                        deudatextBox.Text = (BLL.CobrosBLL.Quincenas(item.Fecha,item.MontoTotal) - item.Abono).ToString();
                        AbonostextBox.Text = item.Abono.ToString();
                        DateTime FechaAct = fechaDateTimePicker.Value;
                        DateTime FechaEmpeño = item.UltimaFechadeVigencia;
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
                }
                CriteriotextBox.Clear();
                GeneralerrorProvider.Clear();
                CobrosdataGridView.Columns["Detalle"].Visible = false;
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
            if (error == 4 && cobroIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(cobroIdNumericUpDown, "Llenar Cobro Id Id");
                paso = true;
            }
            if (error == 5 && int.TryParse(PagosTextBox.Text, out num) == false)
            {
                GeneralerrorProvider.SetError(PagosTextBox, "Debe Digitar numeros");
                paso = true;
            }
            return paso;
        }
        private void CobrosdeEmpeño_Load(object sender, EventArgs e)
        {
            Cobrarbutton.Enabled = false;
            PagosTextBox.ReadOnly = true;
        }
        private decimal Quincenas(DateTime fecha, decimal monto)
        {
            decimal res = 0;
            var resultado = Math.Abs((fecha.Date - fechaDateTimePicker.Value.Date).TotalDays);
            if (resultado <= 15)
            {
                res = monto * Convert.ToDecimal(0.05);
                monto += res;
            }
            if (resultado >= 15 && resultado <= 30)
            {
                res = monto * Convert.ToDecimal(0.10);
                monto += res;
            }
            if (resultado >= 30 && resultado <= 45)
            {
                res = monto * Convert.ToDecimal(0.15);
                monto += res;
            }
            if (resultado >= 60 && resultado <= 75)
            {
                res = monto * Convert.ToDecimal(0.20);
                monto += res;
            }
            if (resultado == 75 && resultado <= 90)
            {
                res = monto * Convert.ToDecimal(0.25);
                monto += res;
            }
            if (resultado == 90 && resultado <= 95)
            {
                res = monto * Convert.ToDecimal(0.30);
                monto += res;
            }
            return monto;
        }
        
        public void SinColumnas()
        {
            CobrosdataGridView.Columns["ID"].Visible = false;
            CobrosdataGridView.Columns["ArticuloId"].Visible = false;
            CobrosdataGridView.Columns["articulos"].Visible = false;
        }
     

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {

            cobroIdNumericUpDown.Value = 0;
            CobrosdataGridView.DataSource = null;
            FiltrocomboBox.SelectedItem = null;
            deudatextBox.Clear();
            PagosTextBox.Clear();
            DesdedateTimePicker.Value = DateTime.Now;
            HastadateTimePicker.Value = DateTime.Now;
            Cobrarbutton.Enabled = false;
            PagosTextBox.ReadOnly = true;
            GeneralerrorProvider.Clear();
            AbonostextBox.Clear();
            estadolabel.Text = "";
            Buscarbutton.Enabled = true;

        }
        
        private Cobros Llenaclase()
        {
            Cobros cobros = new Cobros();
           List<Empeños> detalle = (List<Empeños>)CobrosdataGridView.DataSource;

          int  id = detalle.ElementAt(CobrosdataGridView.CurrentRow.Index).EmpeñoId;
            

            cobros.CobroId = Convert.ToInt32(cobroIdNumericUpDown.Value);
            cobros.Fecha = fechaDateTimePicker.Value;
            cobros.Abono = Convert.ToDecimal(PagosTextBox.Text);
            cobros.EmpeñoId = Convert.ToInt32(id);

         
            return cobros;
        }


        private void Cobrarbutton_Click(object sender, EventArgs e)
        {
            decimal deuda = Convert.ToDecimal(deudatextBox.Text);
            decimal pago = Convert.ToDecimal(PagosTextBox.Text);
         
            if (Validar(5))
            { MessageBox.Show("Debe de Dijitar un Monto!", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cobros cobros = Llenaclase();
                bool paso = false;
                if (cobroIdNumericUpDown.Value == 0)
                {
                    paso = BLL.CobrosBLL.Guardar(Llenaclase());

             
                }
                else
                {
                    int id = Convert.ToInt32(cobroIdNumericUpDown.Value);
                    var entry = BLL.CobrosBLL.Buscar(id);

                    if (entry != null)
                    {
                        paso = BLL.CobrosBLL.Modificar(Llenaclase());
                        
                    }
                    else
                    {
                        MessageBox.Show("Id no existe", "Falló",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void DeudatextBox_TextChanged(object sender, EventArgs e)
        {
         if(deudatextBox.Text != string.Empty )
            {
                PagosTextBox.ReadOnly = false;     
            }
        }

        private void PagosTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PagosTextBox.Text != string.Empty)
            {
                Cobrarbutton.Enabled = true;

            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(4))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(cobroIdNumericUpDown.Value);

                if (BLL.CobrosBLL.Eliminar(id))
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

        private void Buscarcobrobutton_Click(object sender, EventArgs e)
        {
            Buscarbutton.Enabled = false;
            if ( Validar(4))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(cobroIdNumericUpDown.Value);
                Cobros cobros = BLL.CobrosBLL.Buscar(id);
                PagosTextBox.ReadOnly = false;

                if (cobros != null)
                {

                    LlenaCampos(cobros);

                   
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                GeneralerrorProvider.Clear();
            }
        }

        private void LlenaCampos(Cobros cobros)
        {
           
            cobroIdNumericUpDown.Value = cobros.CobroId;
            PagosTextBox.Text = cobros.Abono.ToString();

            CobrosdataGridView.DataSource = BLL.EmpeñosBLL.GetList(x => x.EmpeñoId == cobros.EmpeñoId);

            foreach (var item in BLL.EmpeñosBLL.GetList(x => x.EmpeñoId == cobros.EmpeñoId))
            {

                deudatextBox.Text = (BLL.CobrosBLL.Quincenas(item.Fecha, item.MontoTotal) - item.Abono).ToString();
                AbonostextBox.Text = item.Abono.ToString();


                
                    DateTime FechaAct = fechaDateTimePicker.Value;
                    DateTime FechaEmpeño = item.UltimaFechadeVigencia;
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



            CobrosdataGridView.Columns["ActivodeNegocioId"].Visible = false;
            CobrosdataGridView.Columns["Detalle"].Visible = false;

        }

     

     

    }


}
