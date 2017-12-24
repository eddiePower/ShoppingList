using System.Windows;
using System.Windows.Input;

namespace ShoppingList.ViewModels
{
    public class CrudMenuViewModel
    {
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
      //public ICommand UpdateCommand { get; }


        public CrudMenuViewModel()
        {
           
            AddCommand = new RelayCommand(AddItem);
            EditCommand = new RelayCommand(EditItem);
            DeleteCommand = new RelayCommand(DeleteItem);
        }

        private void AddItem()
        {
           MessageBox.Show("In AddItem ICommand method call.");

        }

        private void EditItem()
        {
            MessageBox.Show("Inside the Edit Item method call");
        }

        private void DeleteItem()
        {
            MessageBox.Show("Inside the delete item method call.");
        }
    }
}
