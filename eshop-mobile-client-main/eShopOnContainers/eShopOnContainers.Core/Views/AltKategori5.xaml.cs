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
    public partial class AltKategori5 : ContentPage
    {
        public AltKategori5()
        {
            InitializeComponent();
        }

        private async void TelefonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TelefonView());
        }

        private async void BulasikMakinesiClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BulasikMakinesiView());
        }

        private async void BuzdolabiClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BuzDolabiView());
        }

    }
}