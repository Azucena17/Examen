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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sucursal gt = new Sucursal("Guatemala");
        Sucursal jlp = new Sucursal("Jalapa");
        Sucursal prog = new Sucursal("El progreso");
        private Sucursal guate;
        private Sucursal jal;
        private Sucursal progre;

        internal Sucursal Gt { get => guate; set => guate = value; }
        internal Sucursal Jlp { get => jal; set => jal = value; }
        internal Sucursal Progre { get => progre; set => progre = value; }

        private void asignar()
        {
            guate = gt;
            jal = jlp;
            progre = prog;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            asignar();
        }
    }
}
