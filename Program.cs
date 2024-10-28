using ApiTesteUds.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using MinimalApiTesteUds.Application.Interfaces.Services;
using MinimalApiTesteUds.Application.Services;
using MinimalApiTesteUds.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient<IExternalApiService, ExternalApiService>();
builder.Services.AddScoped<IExternalApiService, ExternalApiService>();
builder.Services.AddScoped<IExternalApiRepository, ExternalApiRepository>();
builder.Services.AddControllers();
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


app.MapGet("/api/people", async (string? name, string? gender, [FromServices]IExternalApiService service) =>
{
    var result = await service.GetPersonOrFiltersAsync(name, gender);
    return Results.Ok(result);
});

app.Run();