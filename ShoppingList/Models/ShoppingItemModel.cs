using System;

namespace ShoppingList.Models
{
    public class ShoppingItemModel : ObservableObject
    {
        private Guid id;
        private bool enableEdit;
        private string itemName;
        private int itemQty;
        private double itemPrice;

        public ShoppingItemModel()
        {
            id = new Guid();
            enableEdit = false;
            itemName = "Item";
            itemQty = -1;
            itemPrice = 0.00;

        }

        public ShoppingItemModel(Guid aId, bool editMode, string name, int quantity, double price)
        {
            id = aId;
            enableEdit = editMode;
            itemName = name;
            itemQty = quantity;
            itemPrice = price;
        }

        public Guid Id
        {
            get { return id; }
            set { OnPropertyChanged("Id"); }
        }

        public bool EnableEdit
        {
            get { return enableEdit; }
            set
            {
                enableEdit = value;
                OnPropertyChanged("EnableEdit");
            }
        }

        public string ItemName
        {
            get { return itemName; }
            set { OnPropertyChanged("ItemName"); }
        }

        public int ItemQty
        {
            get { return itemQty; }
            set {  OnPropertyChanged("ItemQty"); }
        }

        public double ItemPrice
        {
            get { return itemPrice; }
            set { OnPropertyChanged("ItemPrice"); }
        }

        public override string ToString()
        {
            var itemOutput = "Current item: ";
            itemOutput += "Item GUID: " + Id;
            itemOutput += "\nItem Edit Mode Enabled: " + enableEdit;
            itemOutput += "\nItem Name: " + ItemName;
            itemOutput += "\nItem Quantity: " + ItemQty;
            itemOutput += "\nItem Price: $" + ItemPrice;

            return itemOutput;
        }

    }
}