using System;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Input;
using MvvmDialogs;
using ShoppingList.Models;

namespace ShoppingList.ViewModels
{
    public class ItemDetailEntryViewModel : ObservableObject, IModalDialogViewModel
    {
        private Guid itemId;
        private bool itemEditMode;
        private string itemName;
        private int itemQty;
        private double itemPrice;
        private ShoppingItemModel newItem;
        private ShoppingListViewModel currList;
        private bool? dialogResult;

        public ICommand SaveItemCommand { get; }

        public ItemDetailEntryViewModel(ShoppingListViewModel shopListVm)
        {
            SaveItemCommand = new RelayCommand(SaveAnItem);
            currList = shopListVm;
        }

        private void SaveAnItem()
        {
            //store the entered item details.
            ItemId = Guid.NewGuid();
            ItemEditMode = false;
            ItemName = ItemName;
            ItemQty = ItemQty;
            ItemPrice = ItemPrice;

            newItem = new ShoppingItemModel(ItemId, ItemEditMode, ItemName, ItemQty, ItemPrice);

            // Call the delegate AddItem method
            currList.AddItem(newItem);

            //Close the dialogue box/window & may be give user output message.
            CloseDialogTrue();
        }

        private void CloseDialogTrue()
        {
            DialogResult = true;
        }

        public bool? DialogResult
        {
            get { return dialogResult; }

            private set
            {
                dialogResult = value;
                OnPropertyChanged("DialogResult");
            }
        }

        public Guid ItemId
        {
            get { return itemId; }
            set
            {
                itemId = value;
                OnPropertyChanged("ItemId");
            }
        }

        public string ItemName
        {
            get { return itemName; }
            set
            {
                itemName = value;
                OnPropertyChanged("ItemName");
            }
        }

        public int ItemQty
        {
            get { return itemQty; }
            set
            {
                itemQty = value;
                OnPropertyChanged("ItemQty");
            }
        }

        public double ItemPrice
        {
            get { return itemPrice; }
            set
            {
                itemPrice = value;
                OnPropertyChanged("ItemPrice");
            }
        }

        public bool ItemEditMode
        {
            get { return itemEditMode; }
            set
            {
                itemEditMode = value;
                OnPropertyChanged("ItemEditMode");
            }
        }
    }
}
