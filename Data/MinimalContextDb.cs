using Microsoft.EntityFrameworkCore;
using MyFirstMinimalApi.Models;

namespace MyFirstMinimalApi.Data
{
    public class MinimalContextDb : DbContext
    {
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Document)
                .IsRequired()
                .HasColumnType("varchar(14)");

            modelBuilder.Entity<Supplier>()
                .ToTable("Suppliers");

            base.OnModelCreating(modelBuilder);
        }
    }
}
