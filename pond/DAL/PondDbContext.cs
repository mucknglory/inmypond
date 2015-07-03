using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Pond.Web.DAL
{
    public class PondDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PondDbContext() : base("name=PondDbContext")
        {
        }

        
        public System.Data.Entity.DbSet<Pond.Web.Domain.ServiceProviderAccountState> ServiceProviderAccountStates { get; set; }
        public System.Data.Entity.DbSet<Pond.Web.Domain.ServiceProvider> ServiceProviders { get; set; }
        public System.Data.Entity.DbSet<Pond.Web.Domain.ServiceCategory> ServiceCategories { get; set; }
        public System.Data.Entity.DbSet<Pond.Web.Domain.Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
