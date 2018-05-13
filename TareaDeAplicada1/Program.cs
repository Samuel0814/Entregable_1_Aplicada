using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDeAplicada1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ejercicio_1A());
            Application.Run(new Ejercicio_2B());
            Application.Run(new Ejercicio_2C());
            Application.Run(new Ejercicio_2D());
            Application.Run(new Ejercicio_3A());
            Application.Run(new Ejercicio_3B());
            Application.Run(new Ejercicio_3C());
        }
    }
}
