using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Configuration;
using Reybin.ServiceReport.Resource;

namespace Reybin.ServiceReport.Model
{
    public class AppContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public AppContext()
            : base("Data Source=" + App.DataSourcePath + ";")
        {
        }

        
    }
}
