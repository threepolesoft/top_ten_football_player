using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using top_ten_football_player.Models;
using top_ten_football_player.View;
using top_ten_football_player.ViewModels;
using Xamarin.Forms;

namespace top_ten_football_player
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new top_ten();

        }


        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var dets = e.Item as Item;

            await Navigation.PushAsync(new details(dets));
        }

    }
}
