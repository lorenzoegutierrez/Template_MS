using FluentValidation;

namespace Template_TMS_Application.Request.WeatherForecast.Insert
{
    public class CreateNewWeatherForecastValidator : AbstractValidator<CreateNewWeatherForecastRequest>
    {
        public CreateNewWeatherForecastValidator()
        {
            RuleFor(x => x.TemperatureC)
                .ExclusiveBetween(1,99)
                .WithMessage("La temperatura tiene que estar comprendida entre 1 y 99 grados");

            RuleFor(x => x.Descripcion)
                .NotNull()
                .NotEmpty()
                .WithMessage("Hace falta una descripción");
        }
    }
}
