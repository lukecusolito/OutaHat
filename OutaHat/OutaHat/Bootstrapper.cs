using Autofac;
using Autofac.Util;
using OutaHat.ViewModels;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace OutaHat
{
    public class Bootstrapper
    {
        public IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            RegisterDepenencies(builder);
            return builder.Build();
        }

        protected virtual void RegisterDepenencies(ContainerBuilder builder)
        {
            //builder.RegisterType<SomeRepository>().As<ISomeRepository>().InstancePerLifetimeScope();

            RegisterViewModels(builder);
            RegisterPages(builder);
        }

        private void RegisterViewModels(ContainerBuilder builder)
        {
            var assembly = typeof(ViewModelBase).GetTypeInfo().Assembly;
            var viewModelTypes = assembly.GetLoadableTypes()
                .Where(x => x.IsAssignableTo<ViewModelBase>() && x != typeof(ViewModelBase));
            foreach (var type in viewModelTypes)
            {
                builder.RegisterType(type).AsSelf();
            }
        }
        private void RegisterPages(ContainerBuilder builder)
        {
            var assembly = typeof(ViewModelBase).GetTypeInfo().Assembly;
            var contentPageTypes = assembly.GetLoadableTypes()
                .Where(x => x.IsAssignableTo<ContentPage>() && x != typeof(ContentPage));
            foreach (var type in contentPageTypes)
            {
                builder.RegisterType(type).AsSelf();
            }
        }
    }
}
