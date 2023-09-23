using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rock.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RockContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RockContext") ?? throw new InvalidOperationException("Connection string 'RockContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
