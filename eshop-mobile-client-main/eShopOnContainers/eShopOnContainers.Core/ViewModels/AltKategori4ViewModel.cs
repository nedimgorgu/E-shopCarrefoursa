using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AltKategori4ViewModel
    {

        public INavigation Navigation { get; set; }
        public ICommand SuButonu { get; set; }

        public ICommand CayButonu { get; set; }

        public ICommand KahveButonu { get; set; }

        public ICommand GazozButonu { get; set; }

        public ICommand KolaButonu { get; set; }
        public ICommand EnergyDrinkButonu { get; set; }

        public AltKategori4ViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.SuButonu = new Command(async () => await MoveToSu());
            this.CayButonu = new Command(async () => await MoveToCay());
            this.KahveButonu = new Command(async () => await MoveToKahve());
            this.GazozButonu = new Command(async () => await MoveToGazoz());
            this.KolaButonu = new Command(async () => await MoveToKola());
            this.EnergyDrinkButonu = new Command(async () => await MoveToEnergyDrink());


        }

        private async Task MoveToEnergyDrink()
        {
            await Navigation.PushModalAsync(new EnergyDrinkView()); ;
        }

        private async Task MoveToKola()
        {
            await Navigation.PushModalAsync(new KolaView());
        }

        private async Task MoveToGazoz()
        {
            await Navigation.PushModalAsync(new GazozView());
        }

        private async Task MoveToKahve()
        {
            await Navigation.PushModalAsync(new KahveView());
        }

        private async Task MoveToCay()
        {
            await Navigation.PushModalAsync(new CayView());
        }

        private async Task MoveToSu()
        {
            await Navigation.PushModalAsync(new SuView());
        }
    }
}
