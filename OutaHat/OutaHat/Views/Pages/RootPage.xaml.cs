using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OutaHat.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RootPage : MasterDetailPage
    {
		public RootPage()
		{
			InitializeComponent();
		}
	}
}