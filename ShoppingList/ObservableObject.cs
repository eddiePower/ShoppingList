using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ShoppingList
{
    /*
    * This is the class to implement Inotify class and the onPropertyChanged method
    * that way all our classes that need this can reuse this object rather then 
    * repitition.
    */
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
