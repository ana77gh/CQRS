using CqrsDemo.Infrastructure.Data;
using CqrsDemo.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Reflection;
using CqrsDemo.Application.Common.Behaviours;
using FluentValidation;
using CqrsDemo.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMediatR(cfg => 
    { cfg.RegisterServicesFromAssembly(
        Assembly.Load("CqrsDemo.Application")); 
    });
builder.Services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<AppDbContext>());
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("CqrsDemoDb"));

// Add validation behavior to MediatR pipeline
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
// Register validator
builder.Services.AddValidatorsFromAssembly(Assembly.Load("CqrsDemo.Application"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseMiddleware<GlobalExceptionMiddleware>();
app.MapControllers();

app.Run();
