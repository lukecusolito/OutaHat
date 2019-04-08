using OutaHat.Views.Pages;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OutaHat.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        #region Constructor
        public MenuPageViewModel()
        {
            Title = "OutaHat";
            GoOutaHatPageCommand = new Command(async () => await GoOutaHatPage());
            GoAboutPageCommand = new Command(async () => await GoAboutPage());
        }
        #endregion

        #region Properties
        public ICommand GoOutaHatPageCommand { get; set; }
        public ICommand GoAboutPageCommand { get; set; }
        #endregion

        #region Methods
        async Task GoOutaHatPage()
        {
            await PopRoot();
            App.MenuIsPresented = false;
        }

        async Task GoAboutPage()
        {
            //App.RootPage.Master = new AboutPage();
            //App.Navigation = new NavigationPage(new AboutPage());
            await PushPage(new AboutPage());
            App.RootPage.IsPresented = false;
            App.MenuIsPresented = false;
        }
        #endregion
    }
}
