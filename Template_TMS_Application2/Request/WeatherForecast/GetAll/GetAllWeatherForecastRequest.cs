using MediatR;

using Template_TMS;

namespace Template_TMS_Application.Request.GetAll
{
    public class GetAllWeatherForecastRequest : IRequest<IEnumerable<GetAllWeatherForecastListResponse>>
    {
        public int TemperatureC { get; set; }

        public string? Descripcion { get; set; }
    }
}
