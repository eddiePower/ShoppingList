using System.Windows;
using ShoppingList.ViewModels;

namespace ShoppingList.Views
{
    /// <summary>
    /// Interaction logic for ItemDetailEntry.xaml
    /// </summary>
    public partial class ItemDetailEntry : Window
    {
        public ItemDetailEntry()
        {
            InitializeComponent();
            DataContext = new ItemDetailEntryViewModel(new ShoppingListViewModel());
        }
    }
}
