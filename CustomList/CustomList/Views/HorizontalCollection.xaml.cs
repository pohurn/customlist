using CustomList.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HorizontalCollection : ContentPage
    {
        public HorizontalCollection()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new TestListViewModel();
        }
    }
}