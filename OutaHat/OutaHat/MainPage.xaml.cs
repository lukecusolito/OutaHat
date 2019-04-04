using OutaHat.Models;
using System;
using System.Collections.Generic;
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
        }
        #endregion

        private void OnAddClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(itemEntry.Text))
            {
                hatItems.Add(new HatItem { Text = itemEntry.Text });
                itemEntry.Text = string.Empty;
                displayHatItems.ItemsSource = null; // TODO: Implement property changed event handler
                displayHatItems.ItemsSource = hatItems;
            }
        }
    }
}
