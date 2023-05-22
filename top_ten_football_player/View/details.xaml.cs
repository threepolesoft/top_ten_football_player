using _admob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using top_ten_football_player.Models;
using top_ten_football_player.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace top_ten_football_player.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class details : ContentPage
    {
        public Item Item { get; set; }

        public details(Item des)
        {
            Item = des;

            InitializeComponent();


            _img.Source = des.img.ToString();
            _title.Text = des.title;
            _des.Text = des.des;
        }

    }
}