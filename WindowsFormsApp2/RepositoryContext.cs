using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class RepositoryContext : DbContext
    {
        public RepositoryContext() : base()
        {
        }

        public DbSet<Car> Cars { get; set; }

        // Constructor to use on a DbConnection that is already opened
        public RepositoryContext(DbConnection existingConnection, bool contextOwnsConnection)
          : base(existingConnection, contextOwnsConnection)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().MapToStoredProcedures();
        }
    }
}