using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDeAplicada1
{
    public partial class Ejercicio_3C : Form
    {
        public Ejercicio_3C()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(txtBase.Text);
            double h = Convert.ToDouble(txtAltura.Text);
            double l = Convert.ToDouble(txtLado.Text);
            double a1 = b*h;
            double a2 = (b * h) / 2;
            double p1 = l + l + l;
            double p2 = l*4;
            if (txtOpcion.Text.Trim() == "Perimetro" || txtOpcion.Text.Trim() == "perimetro")
            {
                txtTriangulo.Text = p1.ToString();
                txtCuadrado.Text = p2.ToString();
            }

            if (txtOpcion.Text.Trim() == "Area" || txtOpcion.Text.Trim() == "area")
            {
                txtTriangulo.Text = a1.ToString();
                txtCuadrado.Text = a2.ToString();
            }
        }
    }
}
