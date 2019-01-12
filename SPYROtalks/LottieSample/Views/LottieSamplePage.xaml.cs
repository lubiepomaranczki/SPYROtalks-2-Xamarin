using Xamarin.Forms;
using SPYROtalks.LottieSample.ViewModels;
using System;
using System.Threading.Tasks;
using AsyncAwaitBestPractices;

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

        public void Handle_OnFinish(object sender, EventArgs e)
        {
            CrossFadeElements().SafeFireAndForget(onException: ex => Console.WriteLine(ex));
        }

        public async Task CrossFadeElements()
        {
            var parentAnimation = new Animation();
            var fadeOutAnimation = new Animation(v => AnimationView.FadeTo(0, 250, Easing.CubicInOut));
            var fadeInAnimation = new Animation(v => TextLabel.FadeTo(1, 250, Easing.CubicInOut));


            parentAnimation.Add(0, 0.5, fadeOutAnimation);
            parentAnimation.Add(0.5, 1, fadeInAnimation);

            parentAnimation.Commit(this, "ChildAnimations", 16, 500, null);

        }
    }
}
