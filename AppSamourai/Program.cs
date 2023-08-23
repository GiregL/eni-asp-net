using AppSamourai.Data;
using Microsoft.EntityFrameworkCore;
using TpEni.Repositories;
using TpEni.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SamouraiDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Datasource"));
});

builder.Services.AddScoped<ArmeRepository, ArmeRepository>();
builder.Services.AddScoped<SamouraiRepository, SamouraiRepository>();
builder.Services.AddScoped<ISamouraiServices, SamouraiServicesImpl>();

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