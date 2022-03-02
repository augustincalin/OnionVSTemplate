using Microsoft.EntityFrameworkCore;
using OnionTemplate.Core.Interfaces;
using OnionTemplate.Core.Model;
using OnionTemplate.Core.Services;
using OnionTemplate.Infrastructure;
using OnionTemplate.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<OnionContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.AddTransient<DbContext, OnionContext>();
builder.Services.AddTransient<IRepository<Value>, EFRepository<Value>>();
builder.Services.AddTransient<IValueService, ValueService>();

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
