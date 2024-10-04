using SampleServiceProvider.Infraestructure;
using SampleServiceProvider.Repositories;
using SampleServiceProvider.Services;

var serviceProvider = new ServiceProvider();
serviceProvider.Register<IForecastRepository, ForecastRepository>();
serviceProvider.Register<IForecastService, ForecastService>();

var forecastService = serviceProvider.GetService<IForecastService>();

var yesterdayForecastDTO = forecastService.GetYesterdayForecast();
var todayForecastDTO = forecastService.GetTodayForecast();
var tomorrowForecastDTO = forecastService.GetTomorrowForecast();

Console.WriteLine($"Yesterday: {yesterdayForecastDTO.Date.ToString("yyyy/MM/dd")} - Temp: {yesterdayForecastDTO.Temperature} °C");
Console.WriteLine($"Today: {todayForecastDTO.Date.ToString("yyyy/MM/dd")} - Temp: {todayForecastDTO.Temperature} °C");
Console.WriteLine($"Tomorrow: {tomorrowForecastDTO.Date.ToString("yyyy/MM/dd")} - Temp: {tomorrowForecastDTO.Temperature} °C");
