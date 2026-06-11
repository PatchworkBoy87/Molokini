using Molokini.API.Endpoints;
using Molokini.API.Middleware;
using Molokini.Core.Interfaces;
using Molokini.Core.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Register Exception Handling & ProblemDetails formatting
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins("https://localhost:7003") // Blazor port
              .AllowAnyMethod()
              .AllowAnyHeader());
});

// Map services
builder.Services.AddScoped<IUserService, UserService>();

// Add Blazor frontend
builder.Services.AddScoped(client => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7296") // Web API port
});

var app = builder.Build();

app.UseExceptionHandler();
app.UseCors();

// Map endpoints
app.MapUserEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.WithTitle("Molokini API")
            .WithTheme(ScalarTheme.Saturn)
            .WithDefaultHttpClient(
                ScalarTarget.CSharp,
                ScalarClient.HttpClient
            );
    });
}

app.UseHttpsRedirection();

app.Run();
