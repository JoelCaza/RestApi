using RestApi.Datos;
using RestApi.Entidades;
using RestApi.Negocio;
using RestApi.Web;
using Microsoft.EntityFrameworkCore;
using QRCoder;

var builder = WebApplication.CreateBuilder(args);
var cn = builder.Configuration
    .GetConnectionString("Restaurante");
// Agregar servicios al contenedor.
builder.Services.AddScoped<IPlatoRepositorio, PlatoRepositorio>();
builder.Services.AddScoped<PlatoServicio>();

builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
builder.Services.AddScoped<CategoriaServicio>();
builder.Services.AddScoped<IMesaRepositorio, MesaRepositorio>();
builder.Services.AddScoped<MesaServicio>();

builder.Services.AddDbContext<RestauranteContext>(
    o => o.UseMySql(cn, ServerVersion.AutoDetect(cn)));
var app = builder.Build();

app.MapPlatoEndpoints();
app.MapCategoriaEndpoints();
app.MapMesaEndpoints();


app.Run();   