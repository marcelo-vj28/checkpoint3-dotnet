using CP3.MVC.Application.Services;
using CP3.MVC.Domain.Interfaces;
using CP3.MVC.Infrastructure.Data.AppData;
using CP3.MVC.Infrastructure.Repositories;
using CP3.MVC.MVC.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(x => {
    x.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

builder.Services.AddScoped<IBarcoRepository, BarcoRepository>();
builder.Services.AddScoped<IBarcoApplicationService, BarcoApplicationService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

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
