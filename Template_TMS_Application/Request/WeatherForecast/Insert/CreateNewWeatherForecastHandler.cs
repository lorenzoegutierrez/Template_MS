using Template_TMS_Infraestructure.DatabaseInMemory;
using Template_TMS_Infraestructure.DataContext;

using MediatR;
using FluentValidation.Results;
using Template_TMS_Application.Notifications;
using Template_TMS_Domain.WeatherForecast;

namespace Template_TMS_Application.Request.WeatherForecast.Insert
{
    public class CreateNewWeatherForecastHandler : IRequestHandler<CreateNewWeatherForecastRequest, EntityResult<CreateWeatherForecastResponse>>
    {
        private readonly AppDbContext _repository;
        public CreateNewWeatherForecastHandler(AppDbContext repository)
        {
            _repository = repository;
        }
        public async Task<EntityResult<CreateWeatherForecastResponse>> Handle(CreateNewWeatherForecastRequest request, CancellationToken cancellationToken)
        {
            /*var validationResult = new CreateNewWeatherForecastValidator();
            
            ValidationResult results = validationResult.Validate(request);*/
            
            if (!request.IsValid)
            {                
                request.AddNotification(ErrorTypeResult.InvalidModel.ErrorCode, ErrorTypeResult.InvalidModel.MsgError);
                
                return new EntityResult<CreateWeatherForecastResponse>(request.Notifications, null!)
                {
                    StatusCode = StatusCode.UnprocessableEntity
                };
            }

            var element = new WeatherForecastDb
            {
                Id = new Guid(),
                Date = DateTime.Now,
                Descripcion = request.Descripcion,
                TemperatureC = request.TemperatureC
            };

            _repository.Add(element);
                
            var countResult = await _repository.SaveChangesAsync();

            CreateWeatherForecastResponse response = new()
            {
                Count = countResult
            };

            return new EntityResult<CreateWeatherForecastResponse>(request.Notifications, response) { StatusCode = StatusCode.Create };
        }
    }
}
