using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AltKategori3ViewModel
    {

        public INavigation Navigation { get; set; }
        public ICommand SutButonu { get; set; }

        public ICommand YogurtButonu { get; set; }

        public ICommand PeynirButonu { get; set; }

        public ICommand ZeytinButonu { get; set; }

        public ICommand YumurtaButonu { get; set; }
        public AltKategori3ViewModel(INavigation navigation)
        {

            this.Navigation = navigation;
            this.SutButonu = new Command(async () => await MoveToSut());
            this.YogurtButonu = new Command(async () => await MoveToYogurt());
            this.PeynirButonu = new Command(async () => await MoveToPeynir());
            this.ZeytinButonu = new Command(async () => await MoveToZeytin());
            this.YumurtaButonu = new Command(async () => await MoveToYumurta());

        }

        private async Task MoveToSut()
        {
            await Navigation.PushModalAsync(new SütView());
        }

        private async Task MoveToYogurt()
        {
            await Navigation.PushModalAsync(new YogurtView());
        }

        private async Task MoveToYumurta()
        {
            await Navigation.PushModalAsync(new YumurtaView());
        }

        private async Task MoveToZeytin()
        {
            await Navigation.PushModalAsync(new ZeytinView());
        }

        private async Task MoveToPeynir()
        {
            await Navigation.PushModalAsync(new PeynirView());
        }

        
    }
}
