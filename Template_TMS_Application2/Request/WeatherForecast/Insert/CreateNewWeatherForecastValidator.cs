
using FluentValidation;

namespace Template_TMS_Application.Request.WeatherForecast.Insert
{
    public class CreateNewWeatherForecastValidator : AbstractValidator<CreateNewWeatherForecastRequest>
    {
        public CreateNewWeatherForecastValidator()
        {
            RuleFor(x => x.TemperatureC)
                .LessThan(0);

            RuleFor(x => x.Descripcion)
                .NotNull();

        }
    }
}
