using System;
using Xamarin.Forms;
using SPYROtalks.LottieSample.Views;
using SPYROtalks.RefitSample.Views;

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

        public void Handle_LottieButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LottieSamplePage());
        }

        public void Handle_RefitButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RefitSamplePage());
        }
    }
}
