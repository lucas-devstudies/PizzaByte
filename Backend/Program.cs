
using Backend.Data;
using Backend.Services.Entrega;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ComandaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<EntregaService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
