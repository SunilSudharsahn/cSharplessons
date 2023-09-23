using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Nwind.Models;
using NWind.Models;
using NWindApplication.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddDbContext<NorthwindContext>(
    Options=>Options.UseSqlServer("name=NwindConnectoin"));
builder.Services.AddScoped<RepositoryEmployee>();
builder.Services.AddScoped<RepositoryOrder>();
builder.Services.AddScoped<RepositioryCustomer>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
