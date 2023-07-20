using Microsoft.EntityFrameworkCore;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
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
                builder.HasData(new Category[]
                    {
                        new Category(){ Id=1, CategoryName = "одежда"},
                        new Category(){ Id=2, CategoryName = "автомобили"},
                        new Category(){ Id=3, CategoryName = "товары для животных"}
                    });
            });
            modelBuilder.Entity<Product>(builder =>
            {
                builder.ToTable(nameof(Product)).HasKey(p => p.Id);
                builder.HasOne(p => p.Category);
                builder.HasOne(p => p.Seller);
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
                builder.ToTable(nameof(Basket)).HasKey(p => p.BasketId);
                builder.HasOne(p => p.User);
                builder.HasMany(p => p.Order);
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
