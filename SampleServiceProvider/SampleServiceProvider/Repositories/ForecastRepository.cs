using SampleServiceProvider.Models;

namespace SampleServiceProvider.Repositories
{
    public interface IForecastRepository
    {
        ForecastDTO GetForecastByDate(DateTime date);
    }

    public class ForecastRepository : IForecastRepository
    {
        private static List<ForecastDTO> forecasts = new List<ForecastDTO>
        {
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(-5), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(-4), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(-3), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(-2), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(-1), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date,            Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(1), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(2), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(3), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(4), Temperature = Random.Shared.Next(0, 50) },
            new ForecastDTO{ Date = DateTime.Now.Date.AddDays(5), Temperature = Random.Shared.Next(0, 50) },
        };

        public ForecastDTO GetForecastByDate(DateTime date)
        {
            return forecasts.First(p => p.Date >= date.Date);
        }
    }
}
