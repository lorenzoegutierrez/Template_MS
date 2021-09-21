using AutoMapper;
using AutoMapper.QueryableExtensions;

using MediatR;

using Template_TMS;

using Template_TMS_Infraestructure.DataContext;

namespace Template_TMS_Application.Request.GetAll
{
    public class GetAllWeatherForecastHandler : IRequestHandler<GetAllWeatherForecastRequest, IEnumerable<GetAllWeatherForecastListResponse>>
    {
        private readonly AppDbContext _repository;
        private readonly IMapper _mapper;

        public GetAllWeatherForecastHandler(AppDbContext repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetAllWeatherForecastListResponse>> Handle(GetAllWeatherForecastRequest request, CancellationToken cancellationToken)
        {

            var aux = _repository.WeatherForecast.ToList();

            return _mapper.Map<IEnumerable<GetAllWeatherForecastListResponse>>(_repository.WeatherForecast);            
        }
    }
}
