using CatFinanças.Application.Gastos;
using CatFinanças.Infra.Interfaces;
using CatFinanças.Infra.Repositorys;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container...
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBuscarGastosQuery, BuscarGastosQuery>();
builder.Services.AddScoped<IGastosRepository, GastosRepository>();

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
