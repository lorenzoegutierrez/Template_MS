using Template_TMS;
using Template_TMS_Infraestructure.DatabaseInMemory;

using AutoMapper;

namespace Template_TMS_Infraestructure.Profiles
{
    public class WeatherClient : Profile
    {
        public WeatherClient()
        {
            CreateMap<WeatherForecastDb, GetAllWeatherForecastListResponse> ();
        }
    }
}
