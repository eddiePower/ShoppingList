namespace ShoppingList
{
    public class ShoppingItem : ObservableObject
    {
        private int id;
        private string itemName;
        private int itemQty;
        private double itemPrice;

        public ShoppingItem()
        {
            id = 0;
            itemName = "Item";
            itemQty = -1;
            itemPrice = 0.00;

        }

        public int Id
        {
            get { return id; }
            set { OnPropertyChanged(ref id, value); }
        }

        public string ItemName
        {
            get { return itemName; }
            set { OnPropertyChanged(ref itemName, value); }
        }

        public int ItemQty
        {
            get { return itemQty; }
            set {  OnPropertyChanged(ref itemQty, value); }
        }

        public double ItemPrice
        {
            get { return itemPrice; }
            set { OnPropertyChanged(ref itemPrice, value); }
        }

        public override string ToString()
        {
            var itemOutput = "Current item: ";
            itemOutput += "Item ID: " + Id;
            itemOutput += "\nItem Name: " + ItemName;
            itemOutput += "\nItem Quantity: " + ItemQty;
            itemOutput += "\nItem Price: $" + ItemPrice;

            return itemOutput;
        }

    }
}