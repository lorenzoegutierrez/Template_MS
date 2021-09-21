using Template_TMS_Infraestructure.DatabaseInMemory;
using Template_TMS_Infraestructure.DataContext;

using MediatR;

namespace Template_TMS_Application.Request.WeatherForecast.Insert
{
    public class CreateNewWeatherForecastHandler : IRequestHandler<CreateNewWeatherForecastRequest, int>
    {
        private readonly AppDbContext _repository;
        public CreateNewWeatherForecastHandler(AppDbContext repository)
        {
            _repository = repository;

        }
        public async Task<int> Handle(CreateNewWeatherForecastRequest request, CancellationToken cancellationToken)
        {
            if (request.IsValid)
            {

            }

            var element = new WeatherForecastDb
            {
                Id = new Guid(),
                Date = DateTime.Now,
                Descripcion = request.Descripcion,
                TemperatureC = request.TemperatureC
            };

            _repository.Add(element);
                
            return await _repository.SaveChangesAsync();            
        }
    }
}
