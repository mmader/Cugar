using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cugar
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt fr die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
