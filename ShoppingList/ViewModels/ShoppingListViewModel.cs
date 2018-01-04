using System;
using System.Collections.ObjectModel;
using ShoppingList.Models;

namespace ShoppingList.ViewModels
{
    public class ShoppingListViewModel : ObservableObject
   {
       private ShoppingItemModel _currentItem;
       private ObservableCollection<ShoppingItemModel> _currentList;

       public ShoppingListViewModel()
        {
            _currentList = new ObservableCollection<ShoppingItemModel>();
            _currentItem = new ShoppingItemModel();

        }

        public string ItemName
        {
            get { return _currentItem.ItemName; }
            set
            {
                _currentItem.ItemName = value;
                OnPropertyChanged("ItemName");
                
            }
        }

       public Guid Id
       {
           get { return _currentItem.Id; }
       }

       public bool EnableEdit
        {
           get { return _currentItem.EnableEdit; }
       }

       public double ItemPrice
       {
           get { return _currentItem.ItemPrice; }
       }

       public int ItemQty
       {
           get { return _currentItem.ItemQty; }
       }

        public ObservableCollection<ShoppingItemModel> AddItem(ShoppingItemModel item)
        {
            //wrap try catch - exception when working
            
            _currentList.Add(item);
            CurrentList = _currentList;
            return CurrentList;

        }

       public ObservableCollection<ShoppingItemModel> RemoveItem(ShoppingItemModel item)
       {
           //wrap try catch - exception when working
           OnPropertyChanged("Remove");
           _currentList.Remove(item);
           CurrentList = _currentList;
           return CurrentList;
       }

        public ShoppingItemModel CurrentItem
        {
            get { return _currentItem; }
            set
            {
                _currentItem = value;
                OnPropertyChanged("CurrentItem");
            }
        }

       public ObservableCollection<ShoppingItemModel> CurrentList
       {
           get { return _currentList; }
           set
           {
               _currentList = value;
               OnPropertyChanged("CurrentList");
           }
       }
   }
}
