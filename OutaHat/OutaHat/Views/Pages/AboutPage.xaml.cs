using OutaHat.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OutaHat.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }
    }
}