using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Loginpage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
           // MainPage = new NavigationPage(new PageDos());
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
