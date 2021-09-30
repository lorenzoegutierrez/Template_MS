namespace Template_TMS_Application.Notifications
{
    public class DomainSubdomain
    {
        private const string SEPARATOR = "-";

        public string CodeConvention { get; set; }

        private DomainSubdomain(string codeConvention)
        {
            CodeConvention = codeConvention;
        }

        public static DomainSubdomain NotifWeatherForecast => new DomainSubdomain($"NOTIF{SEPARATOR}NotifWeatherForecast{SEPARATOR}");
    }

    public partial class CatalogErrorCodes
    {
        private CatalogErrorCodes(string codeConvention, ErrorNotif errorNotif)
        {
            ErrorCode = $"{codeConvention}{string.Format(FORMAT, (int)errorNotif) }";
        }

        public string ErrorCode { get; set; }

        private const string FORMAT = "{0:000}";

        private enum ErrorNotif
        {
            DescriptionIsNullOrEmpty,
            WeatherForecastNotFound,            
            WeatherForecastException,
            WeatherForecastInvalidModel,           
            GetPageNumberIsNegative,
            GetPageSizeIsNegative,
            TemperatureCIsNegative,
            InvalidModel
        }
    }
}
