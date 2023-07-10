using Microsoft.EntityFrameworkCore;
using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(builder =>
            {
                builder.ToTable(nameof(Category)).HasKey(p => p.Id);
                builder.HasMany(p => p.Product);
                builder.HasMany(p => p.Seller);
            });
            modelBuilder.Entity<Product>(builder =>
            {
                builder.ToTable(nameof(Product)).HasKey(p => p.Id);
                builder.HasOne(p => p.Category);
                builder.HasMany(p => p.Seller);
            });
            modelBuilder.Entity<Seller>().ToTable(nameof(Seller));
            modelBuilder.Entity<User>(builder =>
            {
                builder.ToTable(nameof(User)).HasKey(p => p.Id);
                builder.HasOne(p => p.Basket).WithOne(p => p.User).
                HasPrincipalKey<User>(p => p.Id).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Basket>(builder =>
            {
                builder.ToTable(nameof(Basket)).HasKey(p => p.Id);
                builder.HasOne(p => p.User);
                builder.HasMany(p => p.Product);
            });
            modelBuilder.Entity<Order>(builder =>
            {
                builder.ToTable(nameof(Order)).HasKey(p => p.Id);
                builder.HasOne(p => p.Basket);
            });
            modelBuilder.Entity<Payment>(builder =>
            {
                builder.ToTable(nameof(Payment)).HasKey(p => p.Id);
                builder.HasOne(p => p.Seller);
            });
        }
    }
}
