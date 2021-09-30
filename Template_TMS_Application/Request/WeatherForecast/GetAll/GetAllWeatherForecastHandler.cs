using Template_TMS;
using Template_TMS_Infraestructure.DataContext;

using AutoMapper;
using MediatR;
using Template_TMS_Application.Notifications;

namespace Template_TMS_Application.Request.GetAll
{
    public class GetAllWeatherForecastHandler : IRequestHandler<GetAllWeatherForecastRequest, EntityResult<IEnumerable<GetAllWeatherForecastResponse>>>
    {
        private readonly AppDbContext _repository;
        private readonly IMapper _mapper;

        public GetAllWeatherForecastHandler(AppDbContext repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<EntityResult<IEnumerable<GetAllWeatherForecastResponse>>> Handle(GetAllWeatherForecastRequest request, CancellationToken cancellationToken)
        {
            var rows = _mapper.Map<IEnumerable<GetAllWeatherForecastResponse>>(_repository.WeatherForecast);

            return new EntityResult<IEnumerable<GetAllWeatherForecastResponse>>(request.Notifications, rows) { StatusCode = StatusCode.Ok };            
        }
    }
}
