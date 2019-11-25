using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RegionManagerDemo.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName]string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}