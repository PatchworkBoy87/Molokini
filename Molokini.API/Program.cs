using Molokini.API.Endpoints;
using Molokini.Core.Interfaces;
using Molokini.Core.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Map services
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

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
