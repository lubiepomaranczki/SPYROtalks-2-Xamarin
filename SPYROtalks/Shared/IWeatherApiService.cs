using System;
using System.Threading.Tasks;
using Refit;

namespace SPYROtalks.Shared
{
    public interface IWeatherApiService
    {
        //api.openweathermap.org/data/2.5/weather? q = wroclaw & appid = fabffdc626e2fa75b8afba242c296dba
        [Get("/2.5/weather?q={cityName}&appid=fabffdc626e2fa75b8afba242c296dba")]
        Task<string> GetWeatherForCity(string cityName);
    }
}
