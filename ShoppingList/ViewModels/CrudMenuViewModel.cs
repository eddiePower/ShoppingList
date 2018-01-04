using System.Windows;
using System.Windows.Input;
using MvvmDialogs;
using ShoppingList.Models;
using ShoppingList.Views;

namespace ShoppingList.ViewModels
{
    public class CrudMenuViewModel : ObservableObject
    {
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
      //public ICommand UpdateCommand { get; private set; }
        private ShoppingListViewModel _shopListVm;
        private ShoppingItemModel _tempItem;
        private ItemDetailEntryViewModel _itemEntry;
        public static IDialogService dialogService;


        public CrudMenuViewModel(ShoppingListViewModel shopListVm)
        {
            dialogService = new DialogService();
            AddCommand = new RelayCommand(AddItem);
            EditCommand = new RelayCommand(EditItem);
            DeleteCommand = new RelayCommand(DeleteItem);
            _shopListVm = shopListVm;
            _itemEntry = new ItemDetailEntryViewModel(_shopListVm);
        }

        private void AddItem()
        {
            var dialogViewModel = _itemEntry;

            if (dialogService != null)
            {
                bool? success = dialogService.ShowDialog<ItemDetailEntry>(this, dialogViewModel);
            }
        }

        private void EditItem(int id)
        {
            MessageBox.Show("Inside the Edit Item method call");
        }

        private void DeleteItem(int id)
        {
            MessageBox.Show("Inside the delete item method call.");
        }
    }
}
