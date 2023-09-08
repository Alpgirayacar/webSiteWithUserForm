using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using webSiteWithUserForm;


IConfiguration configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json")
           .Build();

var builder = WebApplication.CreateBuilder(args);

var connectionString = configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<DatabaseDbContext>(options =>
    options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
