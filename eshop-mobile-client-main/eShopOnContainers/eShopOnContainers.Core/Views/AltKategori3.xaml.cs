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
    public partial class AltKategori3 : ContentPage
    {
        public AltKategori3()
        {
            InitializeComponent();
        }

        private async void SutClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SütView());
        }

        private async void YogurtClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new YogurtView());
        }

        private async void PeynirClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PeynirView());
        }

        private async void ZeytinClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ZeytinView());
        }

        private async void YumurtaClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new YumurtaView());
        }

    }
}