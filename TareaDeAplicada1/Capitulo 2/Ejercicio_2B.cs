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
    public partial class Ejercicio_2B : Form
    {
        public Ejercicio_2B()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double g = Convert.ToDouble(txtGrados.Text);
            double r = (g * (2*3.141516)) / 360;
            txtRadianes.Text = r.ToString();
        }
    }
}
