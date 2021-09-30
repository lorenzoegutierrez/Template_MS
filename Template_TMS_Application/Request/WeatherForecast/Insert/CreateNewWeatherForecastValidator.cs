using FluentValidation;

using Template_TMS_Application.Notifications;

namespace Template_TMS_Application.Request.WeatherForecast.Insert
{
    public class CreateNewWeatherForecastValidator : AbstractValidator<CreateNewWeatherForecastRequest>
    {
        public CreateNewWeatherForecastValidator()
        {
            RuleFor(x => x.TemperatureC)
                .ExclusiveBetween(1, 99)
                .WithMessage(ErrorTypeResult.TemperatureCIsNegative.MsgError);

            RuleFor(x => x.Descripcion)
                .NotNull()
                .NotEmpty()
                .WithMessage(ErrorTypeResult.DescriptionIsNullOrEmpty.MsgError);
        }
    }
}
