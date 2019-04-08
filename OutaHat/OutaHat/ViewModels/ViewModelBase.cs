using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OutaHat.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        protected virtual async Task PushPage(ContentPage page)
        {
            await App.Navigation.PushAsync(page);
        }

        protected virtual async Task PopPage()
        {
            await App.Navigation.PopAsync();
        }

        protected virtual async Task PopRoot()
        {
            await App.Navigation.PopToRootAsync();
        }

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
