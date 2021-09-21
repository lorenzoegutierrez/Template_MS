using Flunt.Notifications;
using Flunt.Validations;

using MediatR;

namespace Template_TMS_Application.Request.WeatherForecast.Insert
{
    public class CreateNewWeatherForecastRequest : Notifiable<Notification>, IRequest<int>
    {        
        public int TemperatureC { get; set; }

        public string? Descripcion { get; set; }              

    }
}
