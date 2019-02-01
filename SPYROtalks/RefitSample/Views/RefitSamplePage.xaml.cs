using Xamarin.Forms;
using SPYROtalks.RefitSample.ViewModels;

namespace SPYROtalks.RefitSample.Views
{
    public partial class RefitSamplePage : ContentPage
    {
        public RefitSamplePage()
        {
            InitializeComponent();
            BindingContext = new RefitSampleViewModel();
        }
    }
}
