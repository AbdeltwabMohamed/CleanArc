using Infrastracutre.Data;
using Infrastracutre;
using Microsoft.EntityFrameworkCore;
using Service;
using Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddDbContext<ApplicationDbContext>
    (opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddInfraConfig()
    .AddServiceConfig()
    .AddCorConfig();

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
