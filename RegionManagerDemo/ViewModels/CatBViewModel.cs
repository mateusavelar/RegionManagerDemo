using Prism.Regions;

namespace RegionManagerDemo.ViewModels
{
    public class CatBViewModel : ViewModelBase, INavigationAware
    {
        public CatBViewModel()
        {
        }

        private string _SomeMessage;

        public string SomeMessage
        {
            get { return _SomeMessage; }
            set
            {
                _SomeMessage = value;
                NotifyPropertyChanged();
            }
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var param = navigationContext.Parameters["navParam"];
            SomeMessage = param.ToString();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}