using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Entities;

namespace YourProply.Entities
{
    public class YourProplyDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=YourProplyDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasDiscriminator<UserType>("UserType")
                .HasValue<Landlord>(UserType.Landlord)
                .HasValue<Tenant>(UserType.Tenant);

            base.OnModelCreating(modelBuilder);
        }
    }
}
