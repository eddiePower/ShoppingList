using System.Windows;
using System.Windows.Controls;
using ShoppingList.ViewModels;

namespace ShoppingList.Views
{
    /// <summary>
    /// Interaction logic for CrudMenu.xaml
    /// </summary>
    public partial class CrudMenu : UserControl
    {
        private CrudMenuViewModel menuVm = new CrudMenuViewModel();

        public CrudMenu()
        {
            InitializeComponent();
            DataContext = menuVm;
        }
    }
}
