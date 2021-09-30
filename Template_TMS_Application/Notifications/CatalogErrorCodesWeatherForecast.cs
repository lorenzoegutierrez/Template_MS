using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_TMS_Application.Notifications
{
    public partial class CatalogErrorCodes
    {
        public static CatalogErrorCodes GetPageNumberIsNegative => new CatalogErrorCodes(
            DomainSubdomain.NotifWeatherForecast.CodeConvention,
            ErrorNotif.GetPageNumberIsNegative
            );

        public static CatalogErrorCodes GetPageSizeIsNegative => new CatalogErrorCodes(
            DomainSubdomain.NotifWeatherForecast.CodeConvention,
            ErrorNotif.GetPageSizeIsNegative
            );
        public static CatalogErrorCodes DescriptionIsNullOrEmpty => new CatalogErrorCodes(
            DomainSubdomain.NotifWeatherForecast.CodeConvention,
            ErrorNotif.DescriptionIsNullOrEmpty
            );
        public static CatalogErrorCodes WeatherForecastNotFound => new CatalogErrorCodes(
            DomainSubdomain.NotifWeatherForecast.CodeConvention,
            ErrorNotif.WeatherForecastNotFound
            );
        public static CatalogErrorCodes WeatherForecastException => new CatalogErrorCodes(
            DomainSubdomain.NotifWeatherForecast.CodeConvention,
            ErrorNotif.WeatherForecastException
            );
                public static CatalogErrorCodes WeatherForecastInvalidModel => new CatalogErrorCodes(
            DomainSubdomain.NotifWeatherForecast.CodeConvention,
            ErrorNotif.WeatherForecastInvalidModel
            );
        public static CatalogErrorCodes TemperatureCIsNegative => new CatalogErrorCodes(
DomainSubdomain.NotifWeatherForecast.CodeConvention,
ErrorNotif.TemperatureCIsNegative
);
        public static CatalogErrorCodes InvalidModel => new CatalogErrorCodes(
    DomainSubdomain.NotifWeatherForecast.CodeConvention,
    ErrorNotif.InvalidModel
    );
    }
}
