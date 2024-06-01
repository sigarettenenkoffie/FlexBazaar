using FlexBazaar.API.ErrorHandling;
using FlexBazaar.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

builder.Services.ConfigureCoreLayer(builder.Configuration);
builder.Services.ConfigureInfrastructureLayer(builder.Configuration);
builder.Services.ConfigureMapster();
builder.Services.ConfigureCors();

builder.Services.AddEndpoints();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseAuthorization();

if (app.Environment.IsDevelopment())
    app.UseCors("AllowOrigin");

app.MapEndpoints();

app.Run();
