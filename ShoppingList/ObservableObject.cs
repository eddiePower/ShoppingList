using System.ComponentModel;

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

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
