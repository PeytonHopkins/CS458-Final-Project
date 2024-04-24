using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CS458FinalProject.Data
{
    public class CS458FinalProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CS458FinalProjectContext() : base("name=CS458FinalProjectContext")
        {
        }

        public System.Data.Entity.DbSet<CS458FinalProject.Contractor> Contractors { get; set; }

        public System.Data.Entity.DbSet<CS458FinalProject.User> Users { get; set; }

        public System.Data.Entity.DbSet<CS458FinalProject.Project> Projects { get; set; }
    }
}
