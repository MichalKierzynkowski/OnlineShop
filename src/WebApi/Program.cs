using Application.Interfaces;
using Application.Services;
using Infrastructure;
using Microsoft.OpenApi.Models;
using Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterTestInfrastructure();

builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.RegisterApplication();

builder.Services.AddSwaggerGen(c =>
{
  c.EnableAnnotations();
  c.SwaggerDoc("v1", new OpenApiInfo { Title = "ShopOnline Api", Version = "v1.0" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1.0"));
}

app.UseAuthorization();

app.MapControllers();

app.Run();
