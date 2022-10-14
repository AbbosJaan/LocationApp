using DataAccess;
using DataAccess.Entity;
using LocationApp.Models;
using LocationApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocationDb")));

builder.Services.AddTransient<IGenericCRUDService<RegionModel>, RegionCRUDService>();
builder.Services.AddTransient<IGenericCRUDService<CountryModel>, CountryCRUDService>();

builder.Services.AddTransient<IGenericRepository<Region>, RegionRepository>();
builder.Services.AddTransient<IGenericRepository<Country>, CountryRepository>();


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
