using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Reybin.ServiceReport.Service;

namespace Reybin.ServiceReport
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var admin = new AppService();
            admin.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
