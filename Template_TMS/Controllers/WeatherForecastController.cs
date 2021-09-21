using Microsoft.AspNetCore.Mvc;

using Template_TMS_Application.Request.GetAll;
using Template_TMS_Application.Request.WeatherForecast.Insert;

using MediatR;

namespace Template_TMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;
        
        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _mediator = mediator;
        }       

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