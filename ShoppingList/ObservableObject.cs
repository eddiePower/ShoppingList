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

        /* Using a generic <T> not always the same 
         * data type so using a generic.
         * CallerMember will get the name of the calling member like method name
         */
        public void OnPropertyChanged<T>(ref T property, T value, [CallerMemberName] string PropertyName = "")
        {
            property = value;
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
