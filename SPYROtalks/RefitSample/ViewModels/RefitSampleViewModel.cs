using System;
using Refit;
using SPYROtalks.Shared;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using SPYROtalks.RefitSample.Models;

namespace SPYROtalks.RefitSample.ViewModels
{
    public class RefitSampleViewModel : BaseViewModel
    {
        private readonly IWeatherApiService weatherApiService;

        public RefitSampleViewModel()
        {
            Title = "Refit sample";
            weatherApiService = RestService.For<IWeatherApiService>("https://api.openweathermap.org/data");
        }

        public string CityName { get; set; }
        public WeatherApiResponseModel Weather { get; set; }

        public ICommand GetWeatherCommand => new Command(async (x) => await OnGetWeather(x));

        private async Task OnGetWeather(object obj)
        {
            try
            {
                if (!string.IsNullOrEmpty(CityName))
                {
                    Weather = await weatherApiService.GetWeatherForCity("wroclaw");
                    CityName = string.Empty;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
