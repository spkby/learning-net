using System.Data.Entity;
using MVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using System;

namespace MVC.DBContext
{
    public class DBContent : DbContext
    {
        public DBContent() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ AppDomain.CurrentDomain.GetData("DataDirectory").ToString()+ "\\Database2.mdf;Integrated Security=True")
        { }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Role>().HasMany(e => e.users).WithRequired(e => e.role)
                .HasForeignKey(e => e.RoleId).WillCascadeOnDelete(false);

            modelBuilder.Entity<User>().HasMany(e => e.messages).WithRequired(e => e.user)
                .HasForeignKey(e => e.UserId).WillCascadeOnDelete(false);
        }
    }
}