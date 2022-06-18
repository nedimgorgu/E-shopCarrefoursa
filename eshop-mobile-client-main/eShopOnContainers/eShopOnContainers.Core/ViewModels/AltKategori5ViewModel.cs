using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AltKategori5ViewModel
    {

        public INavigation Navigation { get; set; }
        public ICommand TelefonButonu { get; set; }

        public ICommand BulasikMakinesiButonu { get; set; }

        public ICommand BuzdolabiButonu { get; set; }

        public AltKategori5ViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.TelefonButonu = new Command(async () => await MoveToTelefon());
            this.BulasikMakinesiButonu = new Command(async () => await MoveToBulasikMakinesi());
            this.BuzdolabiButonu = new Command(async () => await MoveToBuzdolabi());


        }

        private async Task MoveToBuzdolabi()
        {
            await Navigation.PushModalAsync(new BuzDolabiView());
        }

        private async Task MoveToBulasikMakinesi()
        {
            await Navigation.PushModalAsync(new BulasikMakinesiView());
        }

        private async Task MoveToTelefon()
        {
            await Navigation.PushModalAsync(new TelefonView());
        }
    }
}
