using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Reybin.ServiceReport.Service;
using Reybin.ServiceReport.Resource;

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
            AppDomain.CurrentDomain.SetData("DataDirectory", App.AppDataDirPath);

            var admin = new AppService();
            admin.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmNewUser());
        }
    }
}
