using OutaHat.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OutaHat.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
        {
            BindingContext = new MenuPageViewModel();
            Icon = "Hamburger@25x19.png";
            InitializeComponent ();
		}
	}
}