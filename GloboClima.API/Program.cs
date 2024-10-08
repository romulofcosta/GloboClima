using GloboClima.API.Services;
using GloboClima.API.Services.Interfaces;
using GloboClima.Core.Services;
using GloboClima.Infrastructure.ExternalServices.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IWeatherForecastService, WeatherForeCastService>();
builder.Services.AddScoped<IExternalWebApiService, ExternalWebApiService>();

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
