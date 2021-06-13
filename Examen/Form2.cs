using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Sucursal gt;
        Sucursal jlp;
        Sucursal prog;

        private void recibirDatos()
        {
            Form1 form = Owner as Form1;
            gt = form.Gt;
            jlp = form.Jlp;
            prog = form.Progre;
        }

        private void enviarDatos()
        {
            Form1 form = Owner as Form1;
            form.Gt = gt;
            form.Jlp = jlp;
            form.Progre = prog;
        }
 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void selecSucursal(string nombreSucursal, Pizza pizza)
        {
            if(nombreSucursal == gt.nombre)
            {
                gt.agregarPizza(pizza);
            }
            else if (nombreSucursal == jlp.nombre)
            {
                jlp.agregarPizza(pizza);
            }
            else if (nombreSucursal == prog.nombre)
            {
                prog.agregarPizza(pizza);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza(txtNombre.Text, int.Parse(txtPrecio.Text), txtDescripcion.Text);
            selecSucursal(listBoxSucursal.Text, pizza);

            enviarDatos();


            int a = dataGridViewAdmin.Rows.Add();

            dataGridViewAdmin.Rows[a].Cells[0].Value = txtNombre.Text;
            dataGridViewAdmin.Rows[a].Cells[1].Value = txtDescripcion.Text;
            dataGridViewAdmin.Rows[a].Cells[2].Value = txtPrecio.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            recibirDatos();
            listBoxSucursal.Items.Add(gt.nombre);
            listBoxSucursal.Items.Add(jlp.nombre);
            listBoxSucursal.Items.Add(prog.nombre);


        }
    }
}
