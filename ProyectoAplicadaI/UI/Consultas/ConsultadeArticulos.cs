using ProyectoAplicadaI.BLL;
using ProyectoAplicadaI.Entidades;
using ProyectoAplicadaI.UI.VentanasReportes;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Consultas
{
    public partial class ConsultadeArticulos : Form
    {
        public ConsultadeArticulos()
        {
            InitializeComponent();
        }

        Expression<Func<Articulos, bool>> filtro = x => true;

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                        filtro = x => x.ArticuloId == id;

                        if (ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este ID, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;
                case 1://Nombre

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar un Nombre!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtro = x => x.Nombre.Contains(CriteriotextBox.Text);

                        if (ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Nombre, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 2://Inventario

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int inventario = Convert.ToInt32(CriteriotextBox.Text);
                        filtro = x => x.Inventario == inventario;


                        if (ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Inventario, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;
                case 3://todo
                    
                    filtro = x => true;
                    if (ArticulosBLL.GetList(filtro).Count() == 0)
                    {
                        MessageBox.Show("Lista esta Vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
            }
            if (FiltrocomboBox.SelectedItem != null)
            {
                ArticulosdataGridView.DataSource = ArticulosBLL.GetList(filtro);
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

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (ArticulosdataGridView.DataSource != null)
            {
                ArticulosReporte abrir = new ArticulosReporte(ArticulosBLL.GetList(filtro));
                {
                    abrir.Show();
                }
            }
            else
            {
                MessageBox.Show("Grid esta Vacio, No puede hacer se un Reporte ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
