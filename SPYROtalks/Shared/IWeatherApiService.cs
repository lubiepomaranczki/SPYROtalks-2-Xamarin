using System.Threading.Tasks;
using Refit;
using SPYROtalks.RefitSample.Models;

namespace SPYROtalks.Shared
{
    public interface IWeatherApiService
    {
        [Get("/2.5/weather?q={cityName}&appid=fabffdc626e2fa75b8afba242c296dba")]
        Task<WeatherApiResponseModel> GetWeatherForCity(string cityName);
    }
}
