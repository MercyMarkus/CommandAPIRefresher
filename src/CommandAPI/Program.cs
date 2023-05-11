using CommandAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;

services.AddControllers();
// A service is created once per client request (connection).
services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

// You'd need to update this when using a controller based approach
// app.MapGet("/", () => "Hello World!");

app.Run();
