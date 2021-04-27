using CustomList.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomList
{
    public partial class MainPage : ContentPage
    {
        bool canClickHorizontal = false;
        bool canClickVertical = false;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void HorizontalClicked(object sender, EventArgs e)
        {
            if (canClickHorizontal) return;
            canClickHorizontal = true;
            Navigation?.PushAsync(new HorizontalCollection(), false);
            canClickHorizontal = false;
        }

        private void VerticalClicked(object sender, EventArgs e)
        {
            if (canClickVertical) return;
            canClickVertical = true;
            Navigation?.PushAsync(new VerticalCollection(), false);
            canClickVertical = false;
        }
    }
}
