using OutaHat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace OutaHat
{
    public partial class MainPage : ContentPage
    {
        #region Fields
        private List<HatItem> hatItems = new List<HatItem>();
        #endregion

        #region Constructor
        public MainPage()
        {
            InitializeComponent();

            displayHatItems.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                if (sender is ListView lv) lv.SelectedItem = null;
            };
        }
        #endregion

        private void OnAddClicked(object sender, EventArgs e)
        {
            itemEntry.Focus();

            if (!string.IsNullOrWhiteSpace(itemEntry.Text))
            {
                if(!hatItems.Any(x => x.Text.Equals(itemEntry.Text, StringComparison.CurrentCultureIgnoreCase)))
                    hatItems.Add(new HatItem { Text = itemEntry.Text });

                itemEntry.Text = string.Empty;

                displayHatItems.ItemsSource = null; // TODO: Implement property changed event handler
                displayHatItems.ItemsSource = hatItems;
            }

        }

        private void OnRemoveItemClicked(object sender, EventArgs e)
        {
            var item = (HatItem)((Button)sender).CommandParameter;

            RemoveHatItem(item.Text);
        }

        private void OnDrawClicked(object sender, EventArgs e)
        {
            var rnd = new Random();
            var index = rnd.Next(hatItems.Count);

            DisplayAlert("Item Drawn", hatItems[index].Text, "OK");

            RemoveHatItem(hatItems[index].Text);
        }

        private void RemoveHatItem(string itemText)
        {
            hatItems.RemoveAll(x => x.Text == itemText);

            displayHatItems.ItemsSource = null; // TODO: Implement property changed event handler
            displayHatItems.ItemsSource = hatItems;
        }
    }
}
