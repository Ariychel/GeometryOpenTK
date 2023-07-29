using System.ComponentModel;

namespace Visualizer.ViewModels.Base
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        protected ViewModel() { }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
