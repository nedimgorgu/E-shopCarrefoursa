
using eShopOnContainers.Core.Views;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AltKategori1ViewModel
    {
        
        public INavigation Navigation { get; set; }
        public ICommand KırmızıEtKategorisiButonu { get; set; }
       
        public ICommand DenizMahsulleriKategorisiButonu { get; set; }

        public AltKategori1ViewModel(INavigation navigation)
        {

            this.Navigation = navigation;
            this.KırmızıEtKategorisiButonu = new Command(async () => await MoveToKırmızıEtKategorisi());
            this.DenizMahsulleriKategorisiButonu = new Command(async () => await MoveToDenizMahsulleriKategorisi());

        }

        private async Task MoveToDenizMahsulleriKategorisi()
        {
            await Navigation.PushModalAsync(new DenizMahsulleriKategorisiView());
        }

        private async Task MoveToKırmızıEtKategorisi()
        {
            await Navigation.PushModalAsync(new KırmızıEtKategorisiView());
        }

        
    }
}
