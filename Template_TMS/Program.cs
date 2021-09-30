
using Template_TMS_Api.Presenters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IBasePresenter, BasePresenter>();

builder.Services.ConfigureServices();

var app = builder.Build();

app.Configure(app);

app.MapControllers();

app.Run();
