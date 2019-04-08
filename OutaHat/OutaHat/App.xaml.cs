using Autofac;
using OutaHat.Views.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OutaHat
{
    public partial class App : Application
    {
        public static IContainer Container;
        public static NavigationPage Navigation { get; private set; }
        public static RootPage RootPage;

        public App() : this (new Bootstrapper()) { }
        public App(Bootstrapper bootstrapper)
        {
            InitializeComponent();

            Container = bootstrapper.CreateContainer();

            CallMain();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static bool MenuIsPresented
        {
            get
            {
                return RootPage.IsPresented;
            }
            set
            {
                RootPage.IsPresented = value;
            }
        }

        private void CallMain()
        {
            var menuPage = new MenuPage();
            Navigation = new NavigationPage(Container.Resolve<OutaHatPage>());
            RootPage = new RootPage();
            RootPage.Master = menuPage;
            RootPage.Detail = Navigation;
            MainPage = RootPage;
        }
    }
}
