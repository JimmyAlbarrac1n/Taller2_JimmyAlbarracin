using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Data;
using Taller_JimmyAlbarracin.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Taller_JimmyAlbarracinContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Taller_JimmyAlbarracinContext") ?? throw new InvalidOperationException("Connection string 'Taller_JimmyAlbarracinContext' not found.")));
builder.Services.AddDbContext<BurgerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BurgerContext") ?? throw new InvalidOperationException("Connection string 'BurgerContext' not found.")));
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Context") ?? throw new InvalidOperationException("Connection string 'Context' not found.")));

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
