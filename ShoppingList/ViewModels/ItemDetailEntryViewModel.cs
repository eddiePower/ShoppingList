using System.Windows.Input;

namespace ShoppingList.ViewModels
{
    public class ItemDetailEntryViewModel : ObservableObject
    {
        private int itemId;
        private string itemName;
        private int itemQty;
        private double itemPrice;
        private ICommand saveItem;
        private ICommand cancelItem;

        public ItemDetailEntryViewModel()
        {
            
        }

        public int ItemId
        {
            get { return itemId; }
            set
            {
                itemId = value;
            }
        }

        public string ItemName { get; set; }
        public int ItemQty { get; set; }
        public double ItemPrice { get; set; }

    }
}
