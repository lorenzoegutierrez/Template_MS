using System.ComponentModel.DataAnnotations;

namespace Template_TMS_Infraestructure.DatabaseInMemory
{
    public class WeatherForecastDb
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Descripcion { get; set; }        
    }
}
