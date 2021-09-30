using Flunt.Notifications;

using MediatR;

using Template_TMS_Application.Notifications;

using Template_TMS_Domain.WeatherForecast;

namespace Template_TMS_Application.Request.WeatherForecast.Insert
{
    public class CreateNewWeatherForecastRequest : Notifiable<Notification>, IRequest<EntityResult<CreateWeatherForecastResponse>>
    {        
        public int TemperatureC { get; set; }

        public string? Descripcion { get; set; }
    }
}
