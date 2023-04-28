using Microsoft.EntityFrameworkCore;

using Backend.Data;
using Backend.Services.Entrega;
using Backend.Services.Usuarios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ComandaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<EntregaService>();
builder.Services.AddScoped<UsuariosService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
