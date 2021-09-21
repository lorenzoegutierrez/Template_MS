using Microsoft.OpenApi.Models;

using Template_TMS_Infraestructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices();

var app = builder.Build();

app.Configure(app);

app.MapControllers();

app.Run();
