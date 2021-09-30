namespace Template_TMS
{
    public class GetAllWeatherForecastResponse
    {        
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Descripcion { get; set; }
    }
}