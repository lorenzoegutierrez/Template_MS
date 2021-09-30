using Microsoft.AspNetCore.Mvc;

using Template_TMS_Application.Request.GetAll;
using Template_TMS_Application.Request.WeatherForecast.Insert;

using MediatR;
using Template_TMS_Api.Presenters;
using Template_TMS_Domain.WeatherForecast;

namespace Template_TMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;
        private readonly IBasePresenter _presenter;

        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger, IBasePresenter presenter)
        {
            _logger = logger;
            _mediator = mediator;
            _presenter = presenter;
        }       

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetAllWeatherForecastResponse>))]
        public async Task<IActionResult> Get()
        {
            var resultPresenter = _presenter.GetResultEntity<IEnumerable<GetAllWeatherForecastResponse>>(await _mediator.Send(new GetAllWeatherForecastRequest()));
            
            return resultPresenter;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateWeatherForecastResponse))]
        public async Task<IActionResult> CreateTeWeatherForecastAsync([FromBody] CreateNewWeatherForecastRequest input)
        {
            var resultPresenter = _presenter.GetResultEntity(await _mediator.Send(input));
            
            return resultPresenter;
        }
    }
}