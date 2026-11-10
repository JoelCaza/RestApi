using RestApi.Datos;
using RestApi.Entidades;
using RestApi.Negocio;
using RestApi.Web;
using RestApi.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddScoped<ProductoRepositorio>();
builder.Services.AddScoped<ProductoServicio>();

builder.Services.AddScoped<PlatoRepositorio>();
builder.Services.AddScoped<PlatoServicio>();

builder.Services.AddScoped<CategoriaRepositorio>();
builder.Services.AddScoped<CategoriaServicio>();

var app = builder.Build();

app.MapPlatoEndpoints();
app.MapCategoriaEndpoints();

app.Run();   