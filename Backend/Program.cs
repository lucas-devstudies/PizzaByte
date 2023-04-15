var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllers();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
