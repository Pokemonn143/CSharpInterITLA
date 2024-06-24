using AutoBus.Infraestructure.Context;
using AutoMapper;
using IOC.Dependencies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BusDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("BusConnection")));
builder.Services.AddRepositoriesDependencies();
builder.Services.AddAutoMapper(typeof(Profile));
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

app.UseAuthorization();

app.MapControllers();

app.Run();
