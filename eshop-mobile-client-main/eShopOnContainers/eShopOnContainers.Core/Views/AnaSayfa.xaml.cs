using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaSayfa : ContentPage
    {
        public AnaSayfa()
        {
            InitializeComponent();


            var images = new List<string>
            {
                "https://reimg-carrefour.mncdn.com/bannerimage/7desk-coksatan-7042022-2-min_0_MC/8840692170802.png",
                "https://reimg-carrefour.mncdn.com/bannerimage/7-20nisan-desk-gida_0_MC/8840603074610.png",
                "https://reimg-carrefour.mncdn.com/bannerimage/5-20desk-toz-deterjan-min_0_MC/8840593539122.png",
                "https://reimg-carrefour.mncdn.com/bannerimage/desk-ats-7042022-min_0_MC/8840690368562.png"
            };


            Slider.ItemsSource = images;


        }

        private async void MeyveSebzeClicked(object sender, EventArgs e)
        {
            
        }

        private async void EtBalikKumesClicked(object sender, EventArgs e)
        {
           
        }

        private async void SutKahvaltilikClicked(object sender, EventArgs e)
        {
            
        }

        private async void İceceklerClicked(object sender, EventArgs e)
        {
            
        }

        private async void ElektronikClicked(object sender, EventArgs e)
        {
            
        }

        private async void BebekDunyasiClicked(object sender, EventArgs e)
        {
           
        }

    }
}