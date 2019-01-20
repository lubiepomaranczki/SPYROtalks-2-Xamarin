using System.Threading.Tasks;
using Refit;
using SPYROtalks.RefitSample.Models;

namespace SPYROtalks.Shared
{
    public interface IWeatherApiService
    {
        [Get("/data/2.5/weather?q={cityName}&appid={apiKey}&units={units}")]
        Task<WeatherApiResponseModel> GetWeatherForCity(string cityName, string apiKey, UnitsType units);
    }
}

