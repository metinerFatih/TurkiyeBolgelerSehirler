global using TurkiyeBolgelerSehirler.Helpers; // bu namespace alt�nda olu�turdu�um herhanbir s�n�f� projede herhangi bir noktada referans vermeden kullanabilece�im. �rnek i�in Views/Home/Privacy'e bak.
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TurkiyeBolgelerSehirler.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var cs = builder.Configuration.GetConnectionString("BaglantiCumlem");
builder.Services.AddDbContext<UygulamaDbContext>(o => o.UseSqlServer(cs));

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
