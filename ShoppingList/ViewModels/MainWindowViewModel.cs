using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingList.Models;

namespace ShoppingList.ViewModels
{
     public class MainWindowViewModel
     {
         private ShoppingListViewModel shopListVm;
         private CrudMenuViewModel menuVm;
         private List<ShoppingItemModel> currentList;
         private ObservableCollection<ShoppingItemModel> viewList;

        public MainWindowViewModel()
        {
           shopListVm = new ShoppingListViewModel();
           menuVm = new CrudMenuViewModel(shopListVm);
           currentList = new List<ShoppingItemModel>();
           viewList = new ObservableCollection<ShoppingItemModel>();
        }

         public CrudMenuViewModel MenuVm
         {
             get { return menuVm; }
         }

         public ShoppingListViewModel ShopListVm
         {
             get { return shopListVm; }
         }
        
    }
}
