using SampleServiceProvider.Models;
using SampleServiceProvider.Repositories;

namespace SampleServiceProvider.Services
{
    public interface IForecastService
    {
        ForecastDTO GetYesterdayForecast();
        ForecastDTO GetTodayForecast();
        ForecastDTO GetTomorrowForecast();
    }

    public class ForecastService : IForecastService
    {
        private readonly IForecastRepository _forecastRepository;
        public ForecastService(IForecastRepository forecastRepository)
        {
            _forecastRepository = forecastRepository;
        }

        public ForecastDTO GetTodayForecast()
        {
            return _forecastRepository.GetForecastByDate(DateTime.Now.Date);
        }

        public ForecastDTO GetTomorrowForecast()
        {
            return _forecastRepository.GetForecastByDate(DateTime.Now.AddDays(1).Date);
        }

        public ForecastDTO GetYesterdayForecast()
        {
            return _forecastRepository.GetForecastByDate(DateTime.Now.AddDays(-1).Date);
        }
    }
}
