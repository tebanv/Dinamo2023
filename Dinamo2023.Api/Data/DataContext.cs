
using Microsoft.EntityFrameworkCore;
using Dinamo2023.Shared.Entities;

namespace Dinamo2023.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ParamSys> ParamSys { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes  { get; set; }
        public DbSet<UserVehicles> UserVehicles { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ParamSys>().HasIndex(x => x.IdParameterFather).IsUnique();
            modelBuilder.Entity<ParamSys>().HasIndex(x => x.Parameter).IsUnique();
            modelBuilder.Entity<Plan>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<ServiceType>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.PhoneNumber).IsUnique();
            modelBuilder.Entity<UserType>().HasIndex(x => x.RoleName).IsUnique();
            modelBuilder.Entity<Vehicle>().HasIndex(x => x.LicensePlate).IsUnique();
        }
    }

}

