using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RegexFileSorter
{
    internal class ObservableObject : INotifyPropertyChanged
    {
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}