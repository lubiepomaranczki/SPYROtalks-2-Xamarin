using Xamarin.Forms;
using SPYROtalks.LottieSample.ViewModels;

namespace SPYROtalks.LottieSample.Views
{
    public partial class LottieSamplePage : ContentPage
    {
        public LottieSampleViewModel ViewModel
        {
            get { return BindingContext as LottieSampleViewModel; }
        }

        public LottieSamplePage()
        {
            InitializeComponent();
            BindingContext = new LottieSampleViewModel();
        }
    }
}
