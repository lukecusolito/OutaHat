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

        public App() : this (new Bootstrapper()) { }
        public App(Bootstrapper bootstrapper)
        {
            Container = bootstrapper.CreateContainer();

            InitializeComponent();

            MainPage = Container.Resolve<OutaHatPage>();
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
    }
}
