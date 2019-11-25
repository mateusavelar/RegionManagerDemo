using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using RegionManagerDemo.Views;

namespace RegionManagerDemo
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindowView();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CatAView>("CatA");
            containerRegistry.RegisterForNavigation<CatBView>("CatB");
        }
    }
}