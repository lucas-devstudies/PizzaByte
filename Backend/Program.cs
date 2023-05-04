using Microsoft.EntityFrameworkCore;

using Backend.Data;
using Backend.Services.Entrega;
using Backend.Services.Usuarios;
using Backend.Services.Entregadores;
using Backend.Services.CarrinhoService;
using Backend.Services.CarrinhoProdutoService;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ComandaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<EntregaService>();
builder.Services.AddScoped<UsuariosService>();
builder.Services.AddScoped<EntregadoresService>();
builder.Services.AddScoped<CarrinhoService>();
builder.Services.AddScoped<CarrinhoProdutoService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
