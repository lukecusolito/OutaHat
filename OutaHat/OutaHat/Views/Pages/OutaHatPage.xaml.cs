using OutaHat.ViewModels;
using Xamarin.Forms;

namespace OutaHat.Views.Pages
{
    public partial class OutaHatPage : ContentPage
	{
		public OutaHatPage()
		{
			InitializeComponent();
            BindingContext = new OutaHatViewModel();
                       
            hatItemsListView.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                if (sender is ListView lv) lv.SelectedItem = null;
            };
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {

        }

        private void OnAddButtonClick(object sender, System.EventArgs e)
        {
            itemEntry.Focus();
        }
    }
}