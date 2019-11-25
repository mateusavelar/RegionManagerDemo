using Prism.Regions;

namespace RegionManagerDemo.ViewModels
{
    public class CatAViewModel : ViewModelBase, INavigationAware

    {
        public CatAViewModel()
        {
        }

        private string _SomeText;

        public string SomeText
        {
            get { return _SomeText; }
            set
            {
                _SomeText = value;
                NotifyPropertyChanged();
            }
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var param = navigationContext.Parameters["navParam"];
            SomeText = param.ToString();
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