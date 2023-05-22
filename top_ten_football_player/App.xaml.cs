using System;
using top_ten_football_player.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace top_ten_football_player
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new sp());
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
