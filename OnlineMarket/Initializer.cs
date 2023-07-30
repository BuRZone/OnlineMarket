using OnlineMarket.BLL.Service.Implementations;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.DAL;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.DAL.SQLRepositories;

namespace OnlineMarket
{
    public static class Initializer
    {
        public static IServiceCollection InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Category>, CategoryRepository>();
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IBaseRepository<Seller>, SellerRepository>();
            services.AddScoped<IBaseRepository<Product>, ProductRepository>();
            services.AddScoped<IBaseRepository<Basket>, BasketRepository>();
            services.AddScoped<IBaseRepository<Order>, OrderRepository>();
            services.AddScoped<IBaseRepository<SubCategory>, SubCategoryRepository>();
            return services;
        }

        public static IServiceCollection InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISellerService, SellerService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ISubCategoryService, SubCategoryService>();

            return services;
        }
    }
}