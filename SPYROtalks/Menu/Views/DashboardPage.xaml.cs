using System;
using Xamarin.Forms;
using SPYROtalks.Menu.ViewModels;
using SPYROtalks.LottieSample.Views;

namespace SPYROtalks.Menu.Views
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardViewModel ViewModel         {             get { return BindingContext as DashboardViewModel; }         }

        public DashboardPage()
        {
            InitializeComponent();
            BindingContext = new DashboardViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        public async void Handle_LottieButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LottieSamplePage());
        }

        public void Handle_RefitButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
