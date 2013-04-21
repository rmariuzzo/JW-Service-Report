using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Configuration;
using Reybin.ServiceReport.Resource;
using System.Data.EntityClient;
using System.Data.SQLite;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Reybin.ServiceReport.Model
{
    public class AppContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public AppContext() : base ("name=DataContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
