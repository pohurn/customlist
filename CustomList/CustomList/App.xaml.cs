using CustomList.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomList
{
    public partial class App : Application
    {
        public static NavigationPage np;

        public App()
        {
            InitializeComponent();
            np = new NavigationPage(new MainPage());
            MainPage = np;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
