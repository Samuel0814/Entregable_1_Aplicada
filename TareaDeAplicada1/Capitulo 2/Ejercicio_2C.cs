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
    public partial class Ejercicio_2C : Form
    {
        public Ejercicio_2C()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRadianes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txtCentigrados.Text);
            double r = (c * 1.8) + 32;
            txtFahrenheit.Text = r.ToString();
        }

        private void txtGrados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
