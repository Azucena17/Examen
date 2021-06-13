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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPizza.Items.Clear();
            if (comboSucursal.Text == gt.nombre)
            {
                foreach (Pizza pizza in gt.listPizza)
                {
                    comboPizza.Items.Add(pizza.nombre);
                }
            }
        
           
           else if (comboSucursal.Text == jlp.nombre)
            {
                foreach (Pizza pizza in jlp.listPizza)
                {
                    comboPizza.Items.Add(pizza.nombre);
                }
            }
    
              
            else if(comboSucursal.Text == prog.nombre)
            {
                foreach(Pizza pizza in prog.listPizza)
                {
                    comboPizza.Items.Add(pizza.nombre);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            recibirDatos();
            comboSucursal.Items.Add(gt.nombre);
            comboSucursal.Items.Add(jlp.nombre);
            comboSucursal.Items.Add(prog.nombre);
        }
    }
}
