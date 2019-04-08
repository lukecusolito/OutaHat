using System.Threading.Tasks;
using Xamarin.Forms;

namespace OutaHat.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        #region Constructor
        public AboutViewModel()
        {
            Title = "About";

            BuyMeACoffeeCommand = new Command(async() => await BuyMeACoffee());
        }
        #endregion

        #region Properties
        public string Author { get; set; } = "Luke Cusolito";
        public string AuthorEmail { get; set; } = "Luke.Cusolito@Outlook.com";
        public string AuthorOrganisation { get; set; } = "The Bearded Developers";
        
        public Command BuyMeACoffeeCommand { get; }
        #endregion

        #region Methods
        async Task BuyMeACoffee()
        {
            await Application.Current.MainPage.DisplayAlert("Buy me a coffee", "Thanks", "OK");
        }
        #endregion
    }
}
