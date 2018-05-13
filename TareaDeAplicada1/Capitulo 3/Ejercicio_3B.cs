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
    public partial class Ejercicio_3B : Form
    {
        public Ejercicio_3B()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Trim() == "1")
                txtDia.Text = "Lunes";
            if (txtNumero.Text.Trim() == "2")
                txtDia.Text = "Martes";
            if (txtNumero.Text.Trim() == "3")
                txtDia.Text = "Miercoles";
            if (txtNumero.Text.Trim() == "4")
                txtDia.Text = "Jueves";
            if (txtNumero.Text.Trim() == "5")
                txtDia.Text = "Viernes";
            if (txtNumero.Text.Trim() == "6")
                txtDia.Text = "Sabado";
            if (txtNumero.Text.Trim() == "7")
                txtDia.Text = "Domingo";
        }
    }
}
