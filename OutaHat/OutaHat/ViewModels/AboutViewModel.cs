using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OutaHat.ViewModels
{
    public class AboutViewModel : INotifyPropertyChanged
    {
        public AboutViewModel() {
            BuyMeACoffeeCommand = new Command(async() => await BuyMeACoffee());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string author = "Luke Cusolito";
        private string authorEmail = "Luke.Cusolito@Outlook.com";

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }
        public string AuthorEmail { get; set; } = "Luke.Cusolito@Outlook.com";
        public string DisplayMessage { get { return $"Your name is {Author}"; } }
        
        public Command BuyMeACoffeeCommand { get; }
        async Task BuyMeACoffee()
        {
            await Application.Current.MainPage.DisplayAlert("Buy me a coffee", "Thanks", "OK");
        }
    }
}
