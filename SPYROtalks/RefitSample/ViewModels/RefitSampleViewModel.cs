using System;
using Refit;
using SPYROtalks.Shared;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

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

        public ICommand GetWeatherCommand => new Command(async (x) => await OnGetWeather(x));

        private async Task OnGetWeather(object obj)
        {
            try
            {
                var test = await weatherApiService.GetWeatherForCity("wroclaw");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
