using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AnasayfaViewModel
    {

        
          

        public INavigation Navigation { get; set; }
        public ICommand MeyveSebzeButonu { get; set; }

        public ICommand EtBalikKumesButonu { get; set; }

        public ICommand SutKahvaltilikButonu { get; set; }

        public ICommand İceceklerButonu { get; set; }

        public ICommand ElektronikButonu { get; set; }
        public ICommand BebekDunyasiButonu { get; set; }
        
        public List<string> SliderList = new List<string>()
        {
             "https://reimg-carrefour.mncdn.com/bannerimage/7desk-coksatan-7042022-2-min_0_MC/8840692170802.png",
                "https://reimg-carrefour.mncdn.com/bannerimage/7-20nisan-desk-gida_0_MC/8840603074610.png",
                "https://reimg-carrefour.mncdn.com/bannerimage/5-20desk-toz-deterjan-min_0_MC/8840593539122.png",
                "https://reimg-carrefour.mncdn.com/bannerimage/desk-ats-7042022-min_0_MC/8840690368562.png"
        };
    

    public AnasayfaViewModel(INavigation navigation)
        {

            this.Navigation = navigation;
            this.MeyveSebzeButonu = new Command(async () => await MoveToMeyveSebze());
            this.EtBalikKumesButonu = new Command(async () => await MoveToEtBalikKumes());
            this.SutKahvaltilikButonu = new Command(async () => await MoveToSutKahvaltilik());
            this.İceceklerButonu = new Command(async () => await MoveToİcecekler());
            this.ElektronikButonu = new Command(async () => await MoveToElektronik());
            this.BebekDunyasiButonu = new Command(async () => await MoveToBebekDunyasi());
        }

        private async Task MoveToMeyveSebze()
        {
            await Navigation.PushModalAsync(new AltKategori2());
        }

        private async Task MoveToEtBalikKumes()
        {
            await Navigation.PushModalAsync(new AltKategori1());
        }

        private async Task MoveToSutKahvaltilik()
        {
            await Navigation.PushModalAsync(new AltKategori3());
        }

        private async Task MoveToİcecekler()
        {
            await Navigation.PushModalAsync(new AltKategori4());
        }

        private async Task MoveToElektronik()
        {
            await Navigation.PushModalAsync(new AltKategori5());
        }

        private async Task MoveToBebekDunyasi()
        {
            await Navigation.PushModalAsync(new AltKategori6());
        }
    }

}
