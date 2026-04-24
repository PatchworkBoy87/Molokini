using Microsoft.EntityFrameworkCore;
using Molokini.API.Endpoints;
using Molokini.API.Middleware;
using Molokini.Core.Application.Services;
using Molokini.Core.Application.Interfaces;
using Molokini.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

// Register Global Exception Handler and Problem Details
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();
// adding notes

builder.Services.AddDbContext<MolokiniDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services and interfaces
builder.Services.AddScoped<IWasteService, WasteService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseExceptionHandler();

// Map endpoints
app.MapUserEndpoints();
app.MapWasteEndpoints();

app.UseHttpsRedirection();

app.Run();
