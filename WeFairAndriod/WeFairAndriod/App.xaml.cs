using System;
using WeFairAndriod.Services;
using WeFairAndriod.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeFairAndriod
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
