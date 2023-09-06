using FactoryMethodAPI2.Concrete;
using FactoryMethodAPI2.Data;
using FactoryMethodAPI2.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddTransient<Ipatient, InPatient>();
builder.Services.AddTransient<Ipatient, OutPatient>();
builder.Services.AddTransient<Ipatient, CasualPatient>();

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
