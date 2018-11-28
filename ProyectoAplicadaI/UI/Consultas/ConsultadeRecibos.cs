using ProyectoAplicadaI.Entidades;
using ProyectoAplicadaI.UI.VentanasReportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Consultas
{
    public partial class ConsultadeRecibos : Form
    {
        public ConsultadeRecibos()
        {
            InitializeComponent();
        }

        Expression<Func<Empeños, bool>> filtro = x => true;
        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            switch (FiltrocomboBox.SelectedIndex)
            {

                case 0://ReciboId

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
                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.EmpeñoId == id && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
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


                case 1:// ClienteId 

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

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.ClienteId == id && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.ClienteId == id;
                        }

                        if (BLL.EmpeñosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 2://NombredeCliente

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


                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.NombredeCliente.Contains(CriteriotextBox.Text) && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.NombredeCliente.Contains(CriteriotextBox.Text);
                        }

                        if (BLL.EmpeñosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

               

                case 3:// Monto

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Monto!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        decimal monto = Convert.ToDecimal(CriteriotextBox.Text);


                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.MontoTotal == monto && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.MontoTotal== monto;
                        }

                        if (BLL.EmpeñosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;


                case 4://TODO
                    filtro = x => true;

                    if (BLL.EmpeñosBLL.GetList(filtro).Count() == 0)
                    {
                        MessageBox.Show("Lista esta Vacia, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
            }

            if (FiltrocomboBox.SelectedItem != null)
            {
                RecibodataGridView.DataSource = BLL.EmpeñosBLL.GetList(filtro);
                CriteriotextBox.Clear();
                GeneralerrorProvider.Clear();
                RecibodataGridView.Columns["Detalle"].Visible = false;


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

            private void ConsultadeRecibos_Load(object sender, EventArgs e)
            {

            
            }

            private void Imprimirbutton_Click(object sender, EventArgs e)
            {
                Empeños recibo = new Empeños();
                if (RecibodataGridView.Rows.Count > 0 && RecibodataGridView.CurrentRow != null)
                {
                    List<Empeños> detalle = (List<Empeños>)RecibodataGridView.DataSource;     
                    int id = detalle.ElementAt(RecibodataGridView.CurrentRow.Index).EmpeñoId;
                VentanaReciboReporte abrir = new VentanaReciboReporte(BLL.EmpeñosBLL.GetList(x => x.EmpeñoId == id));
                abrir.Show();
            }
            else
            {
                MessageBox.Show("No Hay Nada dentro del Grid", "Validacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            }

        private void Listabutton_Click(object sender, EventArgs e)
        {
            if (RecibodataGridView.Rows.Count > 0 && RecibodataGridView.CurrentRow != null)
            {
                VentanadeListadeEmpeños abrir = new VentanadeListadeEmpeños(BLL.EmpeñosBLL.GetList(filtro));
                abrir.Show();
            }
            else
            {
                MessageBox.Show("No Hay Nada dentro del Grid", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

     
    }
}
