using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AltKategori2ViewModel
    {
        public INavigation Navigation { get; set; }
        public ICommand MeyveButonu { get; set; }
        public ICommand SebzeButonu { get; set; }

        public AltKategori2ViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.MeyveButonu = new Command(async () => await MoveToMeyve());
            this.SebzeButonu = new Command(async () => await MoveToSebze());
        }

        private async Task MoveToSebze()
        {
            await Navigation.PushModalAsync(new SebzeView());
        }

        private async Task MoveToMeyve()
        {
           await Navigation.PushModalAsync(new MeyveView());
        }
    }
}
