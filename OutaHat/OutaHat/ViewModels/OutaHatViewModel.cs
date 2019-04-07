using OutaHat.Views.Pages;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OutaHat.ViewModels
{
    public class OutaHatViewModel : ViewModelBase
    {
        #region Fields
        private string newItemEntry = string.Empty;
        #endregion

        #region Constructor
        public OutaHatViewModel()
        {
            AddItemToHatCommand = new Command(async () => await AddItemToHat());
            RemoveItemFromHatCommand = new Command<string>((selectedItem) => RemoveItemFromHat(selectedItem));
            DrawItemFromHatCommand = new Command(async () => await DrawItemFromHat());
        }
        #endregion

        #region Properties
        public ObservableCollection<string> HatItems { get; set; } = new ObservableCollection<string>();
        public string NewItemEntry { get; set; }

        public Command AddItemToHatCommand { get; }
        public Command RemoveItemFromHatCommand { get; }
        public Command DrawItemFromHatCommand { get; }
        #endregion

        #region Methods

        async Task AddItemToHat()
        {
            if (!string.IsNullOrWhiteSpace(NewItemEntry))
            {
                if (!HatItems.Any(x => x.Equals(NewItemEntry, StringComparison.CurrentCultureIgnoreCase)))
                {
                    HatItems.Add(NewItemEntry);
                    NewItemEntry = string.Empty;

                    OnPropertyChanged(nameof(HatItems));
                    OnPropertyChanged(nameof(NewItemEntry));
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(string.Empty, "Item already added.", "OK");
                }
            }
        }

        void RemoveItemFromHat(string item)
        {
            HatItems.Remove(item);

            OnPropertyChanged(nameof(HatItems));
        }

        async Task DrawItemFromHat()
        {
            //if(HatItems.Count == 0)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Hmmm...", "There are no items left to draw", "OK");
            //    return;
            //}

            //var rnd = new Random();
            //var index = rnd.Next(HatItems.Count);
            //var itemDrawn = HatItems[index];

            //await Application.Current.MainPage.DisplayAlert("You Just Drew...", itemDrawn, "OK");

            //RemoveItemFromHat(itemDrawn);
            
            //await Navigation.
        }

        #endregion
    }
}
