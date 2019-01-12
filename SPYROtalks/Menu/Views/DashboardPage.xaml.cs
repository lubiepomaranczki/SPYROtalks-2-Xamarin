using System;
using Xamarin.Forms;
using SPYROtalks.LottieSample.Views;

namespace SPYROtalks.Menu.Views
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
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
