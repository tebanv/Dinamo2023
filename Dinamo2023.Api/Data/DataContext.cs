
using Microsoft.EntityFrameworkCore;
using Dinamo2023.Shared.Entities;

namespace Dinamo2023.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Service>().HasIndex(x => x.Name).IsUnique();
        }
    }

}
}
