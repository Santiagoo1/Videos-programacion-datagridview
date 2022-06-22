using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Videos_programacion
{
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            Producto NuevoProd;
            NuevoProd = new Producto(int.Parse (textBoxCodigo.Text), textBoxDescripcion.Text);
            labelCodigo.Text =NuevoProd.p_Codigo.ToString();
            labelDescripcion.Text = NuevoProd.p_Descripcion;
            LabelStock.Text = "hay" + NuevoProd.p_Stock.ToString() + " unidades ";

            MessageBox.Show("Producto instanciado");


            //agregamos nuevos renglones

            int n = dataGridViewProductos.Rows.Add();

            //colocamos la informacion

            dataGridViewProductos.Rows[n].Cells[0].Value = textBoxDescripcion.Text;
            dataGridViewProductos.Rows[n].Cells[1].Value = textBoxCodigo.Text;
            dataGridViewProductos.Rows[n].Cells[2].Value = textBoxStock.Text;
            tabControl1.SelectedIndex = 1;
        }

        private void ButtomCargar_Click(object sender, EventArgs e)
        {
           
            

        }

        private void radioButtonIngreso_CheckedChanged(object sender, EventArgs e)
        {
            //Producto Ingresar = new Ingreso();
        }
    }
}
