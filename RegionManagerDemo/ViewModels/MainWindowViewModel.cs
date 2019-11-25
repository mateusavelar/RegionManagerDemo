using Prism.Regions;
using System;
using System.Windows.Input;

namespace RegionManagerDemo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            ShowMenuItem1 = new RelayCommand(DoOnShowMenuItem1);
            ShowMenuItem2 = new RelayCommand(DoOnShowMenuItem2);
            _regionManager = regionManager;
        }

        //Request navigation to that region from contentcontrol, to the registration with CatA as a Key....
        private void DoOnShowMenuItem1()
        {
            var parameters = new NavigationParameters();
            parameters.Add("navParam", $"Message to CatA Date:{DateTime.Now}");
            _regionManager.RequestNavigate("mainRegion", "CatA", parameters);
        }

        private void DoOnShowMenuItem2()
        {
            var parameters = new NavigationParameters();
            parameters.Add("navParam", $"Message to CatB Date:{DateTime.Now}");
            _regionManager.RequestNavigate("mainRegion", "CatB", parameters);
        }

        public ICommand ShowMenuItem1 { get; private set; }
        public ICommand ShowMenuItem2 { get; private set; }
    }
}