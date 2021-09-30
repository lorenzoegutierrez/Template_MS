using Template_TMS;

using MediatR;
using Flunt.Notifications;
using Template_TMS_Application.Notifications;

namespace Template_TMS_Application.Request.GetAll
{
    public class GetAllWeatherForecastRequest : Notifiable<Notification>, IRequest<EntityResult<IEnumerable<GetAllWeatherForecastResponse>>>
    {
        public int TemperatureC { get; set; }

        public string? Descripcion { get; set; }
    }
}
