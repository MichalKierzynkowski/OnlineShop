using Application.Interfaces;
using Application.Services;
using Infrastructure;
using Microsoft.OpenApi.Models;
using Application;
using Domain.Interfaces;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterTestInfrastructure();
builder.Services.RegisterApplication();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
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
