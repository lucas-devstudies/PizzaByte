using Backend.Data;
using Backend.Services.Usuarios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add connection
builder.Services.AddDbContext<ComandaDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<UsuariosService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
