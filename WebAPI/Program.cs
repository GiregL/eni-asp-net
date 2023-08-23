using AppSamourai.Data;
using Microsoft.EntityFrameworkCore;
using TpEni.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SamouraiDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Datasource"));
});

builder.Services.AddScoped<SamouraiDbContext, SamouraiDbContext>();
builder.Services.AddScoped<ArmeRepository, ArmeRepository>();
builder.Services.AddScoped<SamouraiRepository, SamouraiRepository>();
builder.Services.AddScoped<ArtMartialRepository, ArtMartialRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();