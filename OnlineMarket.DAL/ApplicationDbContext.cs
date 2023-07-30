using Microsoft.EntityFrameworkCore;
using OnlineMarket.DAL.Entity;
using System.Security.Cryptography;
using System.Text;

namespace OnlineMarket.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.ToTable(nameof(User));
                builder.HasKey("Id");
                builder.HasOne(p => p.Basket).WithOne(p => p.User).HasForeignKey<Basket>(e => e.UserId);


            });
            modelBuilder.Entity<Basket>(builder =>
            {
                builder.ToTable(nameof(Basket));
                builder.HasKey("Id");
                builder.HasOne(p => p.User).WithOne(p => p.Basket).HasForeignKey<Basket>(e => e.UserId);

            });
            modelBuilder.Entity<Seller>(builder =>
            {
                builder.ToTable(nameof(Seller));
                builder.HasKey("Id");
                builder.HasOne(p => p.User);

            });
            modelBuilder.Entity<Category>(builder =>
            {
                builder.ToTable(nameof(Category));
                builder.HasKey("Id");
                builder.HasMany(p => p.SubCategory).WithOne(p => p.Category);

            });
            modelBuilder.Entity<SubCategory>(builder =>
            {
                builder.ToTable(nameof(SubCategory));
                builder.HasKey("Id");
                builder.HasOne(p => p.Category).WithMany(p => p.SubCategory);

            });

            modelBuilder.Entity<Product>(builder =>
            {
                builder.ToTable(nameof(Product));
                builder.HasKey("Id");
                builder.HasOne(p => p.SubCategory).WithMany(p =>p.Product);
               
            });
    
            modelBuilder.Entity<Order>(builder =>
            {
                builder.ToTable(nameof(Order));
                builder.HasKey("Id");
                builder.HasOne(p => p.Basket);
                builder.HasOne(p => p.Product);

            });
            modelBuilder.Entity<Payment>(builder =>
            {
                builder.ToTable(nameof(Payment));

            });
        }
    }
}
