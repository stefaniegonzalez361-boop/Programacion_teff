using System;
using System.Windows.Forms;

namespace Examen_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // ✅ Asegúrate de que el formulario se llame "Form1"
        }
    }
}
