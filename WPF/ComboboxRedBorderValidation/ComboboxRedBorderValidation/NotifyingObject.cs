using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ComboboxRedBorderValidation
{
    public abstract class NotifyingObject : INotifyPropertyChanged, IRaisePropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        void IRaisePropertyChanged.RaisePropertyChanged(string propertyName)
        {
            // ReSharper disable once ExplicitCallerInfoArgument
            OnPropertyChanged(propertyName);
        }
    }
}