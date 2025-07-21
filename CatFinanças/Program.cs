using CatFinan�as.Application.Gastos;
using CatFinan�as.Infra.Interfaces;
using CatFinan�as.Infra.Persistencia;
using CatFinan�as.Infra.Repositorys;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container....
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBuscarGastosQuery, BuscarGastosQuery>();
builder.Services.AddScoped<IGastosRepository, GastosRepository>();

var connectionString = builder.Configuration.GetConnectionString("CatConnection");

builder.Services.AddDbContext<CatFinancasContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
