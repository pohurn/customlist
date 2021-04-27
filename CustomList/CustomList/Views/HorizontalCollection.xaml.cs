using CustomList.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static CustomList.Viewmodels.TestListViewModel;

namespace CustomList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HorizontalCollection : ContentPage
    {
        bool canSelectItem = false;
        public HorizontalCollection()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new TestListViewModel();
        }

        private async void ItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if (canSelectItem) return;
            canSelectItem = true;
            var item = e.CurrentSelection;
            if (item.Count == 1)
            {
                var data = item.FirstOrDefault();
                if (data != null)
                {
                    var dataselected = (Customer)data;
                    await DisplayAlert("Item Selected", "You have selected item with name: " + dataselected.NAME, "OK");
                }
            }
            canSelectItem = false;
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}