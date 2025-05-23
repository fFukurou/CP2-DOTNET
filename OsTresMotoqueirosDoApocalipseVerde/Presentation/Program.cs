using Microsoft.EntityFrameworkCore;
using OsTresMotoqueirosDoApocalipseVerde.Infraestructure;
using System;

var builder = WebApplication.CreateBuilder(args);

// ENV VARIABLES
builder.Configuration.AddEnvironmentVariables();

var connectionString = builder.Configuration["ConnectionStrings:OracleConnection"];

// DATABASE
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(connectionString));

// AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
