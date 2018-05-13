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
    public partial class Ejercicio_3A : Form
    {
        public Ejercicio_3A()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(txtNumero.Text);
            string c1;

            if (b % 2 == 0)
            {
                c1 = "Es Par";
                txtVerificar.Text = c1.ToString();
            }

            else
            {
                c1 = "Es Impar";
                txtVerificar.Text = c1.ToString();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
