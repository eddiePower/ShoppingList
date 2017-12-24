using System.Collections.Generic;
using System.Windows;

namespace ShoppingList.ViewModels
{
    public class ShoppingListViewModel : ObservableObject
    {
        private List<ShoppingItem> currentList;
       

        public ShoppingListViewModel()
        {
           currentList = new List<ShoppingItem>();
           ShoppingItem item = new ShoppingItem();
            item.Id = 1;
            item.ItemName = "Milk 2L";
            item.ItemQty = 2;
            item.ItemPrice = 2.50;
            MessageBox.Show("The item in shop list constructor is " + item.ToString());
            AddItem(item);   
        }

        public void AddItem(ShoppingItem item)
        {
            currentList.Add(item);
        }

        public List<ShoppingItem> CurrentList { get; set; }
    }
}
