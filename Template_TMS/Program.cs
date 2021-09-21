using Microsoft.OpenApi.Models;

using Template_TMS_Infraestructure;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
/*builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Template_TMS", Version = "v1" });
});*/

builder.Services.ConfigureServices();

var app = builder.Build();

app.Configure(app);

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Template_TMS v1"));
}*/

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
