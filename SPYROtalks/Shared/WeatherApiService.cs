using System.Threading.Tasks;
using SPYROtalks.RefitSample.Models;

namespace SPYROtalks.Shared
{
    public class WeatherApiService : BaseApiService, IWeatherApiService
    {
        public WeatherApiService(string apiUrl) : base(apiUrl)
        {
        }

        public async Task<WeatherApiResponseModel> GetWeatherForCity(string cityName, string apiKey, UnitsType units)
        {
            return await GetAsync<WeatherApiResponseModel>($"data/2.5/weather?q={cityName}&appid={apiKey}&units={units}");
        }
    }
}
