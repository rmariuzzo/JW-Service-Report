using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Reybin.ServiceReport.Resource
{
    public class App
    {

        private const String AppDataDirName = "JW-Service-Report";

        private static String _AppDataDirPath;

        public static String AppDataDirPath
        {
            get
            {
                if (_AppDataDirPath == null)
                {
                    _AppDataDirPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + AppDataDirName;
                }
                return _AppDataDirPath;
            }
        }

        private static String _DataSourcePath;

        public static String DataSourcePath
        {
            get
            {
                if (_DataSourcePath == null)
                {
                    _DataSourcePath = App.AppDataDirPath + "\\" + ConfigurationManager.AppSettings["db.datasource"];
                }
                return _DataSourcePath;
            }
        }

        private App() { }


    }
}
