using System;
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
        //public INavigation Navigation { get; }

        //protected ViewModelBase(INavigation navigation)
        //{
        //    Navigation = navigation;
        //}

        public virtual void Init(object initData)
        {
        }

        public void WireEvents(Page page)
        {
            page.Appearing += ViewIsAppearing;
            page.Disappearing += ViewIsDisappearing;
        }
        protected virtual void ViewIsDisappearing(object sender, EventArgs e)
        {
        }

        protected virtual void ViewIsAppearing(object sender, EventArgs e)
        {
        }

        //protected virtual async Task PushPage(ContentPage page)
        //{
        //    await Navigation.PushAsync(page);
        //}

        //protected virtual async Task PopPage()
        //{
        //    await Navigation.PopAsync();
        //}

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
