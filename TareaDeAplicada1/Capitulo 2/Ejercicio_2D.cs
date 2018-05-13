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
    public partial class Ejercicio_2D : Form
    {
        public Ejercicio_2D()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txtDolares.Text);
            double v = Convert.ToDouble(txtValor.Text);
            double r = d / v;
            txtEuros.Text = r.ToString();
        }
    }
}
