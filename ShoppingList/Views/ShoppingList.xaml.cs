using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ShoppingList.ViewModels;

namespace ShoppingList.Views
{
    /// <summary>
    /// Interaction logic for ShoppingList.xaml
    /// </summary>
    public partial class ShoppingList : UserControl
    {
        public ShoppingList()
        {
            InitializeComponent();
            ShoppingItem item = new ShoppingItem();
            List<ShoppingItem> currList = new List<ShoppingItem>();
            item.Id = 1;
            item.ItemName = "Milk";
            item.ItemQty = 2;
            item.ItemPrice = 2.50;

            MessageBox.Show("Adding item " + item.ToString());
            currList.Add(item);
            ItemsListView.ItemsSource = currList;

        }
    }
}
