using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    //public class SqlDbContext<T> : SqlDbContext where T : BaseEntity
    //{
    //    public DbSet<T> Entities { get; set; }
    //}
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("17bang")
        {
            Database.Log = s => Debug.WriteLine(s);
        }

        //public DbSet<User> users { get; set; }
        //public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Article>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
