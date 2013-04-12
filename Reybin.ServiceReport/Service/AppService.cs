using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Data.SQLite;
using Reybin.ServiceReport.Model;
using System.Resources;
using Reybin.ServiceReport.Properties;
using Reybin.ServiceReport.Resource;

namespace Reybin.ServiceReport.Service
{
    public class AppService
    {
        public void Init()
        {
            if (!Directory.Exists(App.AppDataDirPath))
            {
                Directory.CreateDirectory(App.AppDataDirPath);
            }

            if (!File.Exists(App.DataSourcePath))
            {
                SQLiteConnection.CreateFile(App.DataSourcePath);
                using (var ctx = new AppContext())
                {
                    var conn = new SQLiteConnection(ctx.Database.Connection.ConnectionString);
                    conn.Open();
                    var init = new SQLiteCommand(Resources.InitDdl, conn);
                    init.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
