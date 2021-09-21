
using MediatR;

using Microsoft.AspNetCore.Mvc;

using Template_TMS_Application.Request.GetAll;
using Template_TMS_Application.Request.WeatherForecast.Insert;

namespace Template_TMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;
        //private readonly INotifierMediatorService _notificationPresenter;
        private readonly IConfiguration _configuration;
       // private readonly IMapper _mapper;

        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _mediator = mediator;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetAllWeatherForecastListResponse))]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllWeatherForecastRequest());
            
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateTeWeatherForecastAsync([FromBody] CreateNewWeatherForecastRequest input)
        {
            var result = await _mediator.Send(input);
            
            return Ok(result);
        }
    }
}