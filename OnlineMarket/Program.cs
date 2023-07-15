using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using OnlineMarket;
using OnlineMarket.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>();

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddSqlServer<ApplicationDbContext>(connectionString);

//builder.Services.AddSingleton(new MongoClient("mongodb://localhost:27017"));

builder.Services.InitializeRepositories();
builder.Services.InitializeServices();


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
   AddCookie(o =>
   {
       o.LoginPath = new PathString("/Account/Login");
       o.AccessDeniedPath = new PathString("/Account/Login");
   });
builder.Services.AddAuthorization(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
