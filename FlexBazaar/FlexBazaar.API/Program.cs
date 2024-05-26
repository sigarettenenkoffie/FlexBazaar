var builder = WebApplication.CreateBuilder(args);


// builder.Services.AddControllers();

builder.Services.AddEndpoints();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureCors();

builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseAuthorization();

app.UseCors("AllowOrigin"); // Enable CORS

// app.MapControllers();

// app.MapControllerRoute(
//     name: "default",
    // pattern: "{controller=WhatEver}/{action=Index}/{id?}");

app.MapEndpoints();

app.Run();
