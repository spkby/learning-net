using System.Data.Entity;
using BusStation.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using System;

namespace BusStation.DBContext
{
    public class DBContent : DbContext
    {
        public DBContent() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="
            + AppDomain.CurrentDomain.GetData("DataDirectory").ToString() + "\\Database.mdf;Integrated Security=True")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Role>().HasMany(e => e.Users).WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleId).WillCascadeOnDelete(false);

            modelBuilder.Entity<City>().HasMany(e => e.RoutesTo).WithRequired(e => e.CityTo)
.HasForeignKey(e => e.CityIdTo).WillCascadeOnDelete(false);

            modelBuilder.Entity<City>().HasMany(e => e.RoutesFrom).WithRequired(e => e.CityFrom)
   .HasForeignKey(e => e.CityIdFrom).WillCascadeOnDelete(false);

            modelBuilder.Entity<Bus>().HasMany(e => e.Trips).WithRequired(e => e.Bus)
               .HasForeignKey(e => e.BusId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Route>().HasMany(e => e.Trips).WithRequired(e => e.Route)
                .HasForeignKey(e => e.RouteId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Trip>().HasMany(e => e.Tickets).WithRequired(e => e.Trip)
    .HasForeignKey(e => e.TripId).WillCascadeOnDelete(false);

            modelBuilder.Entity<User>().HasMany(e => e.Tickets).WithRequired(e => e.User)
    .HasForeignKey(e => e.UserId).WillCascadeOnDelete(false);

        }
    }
}