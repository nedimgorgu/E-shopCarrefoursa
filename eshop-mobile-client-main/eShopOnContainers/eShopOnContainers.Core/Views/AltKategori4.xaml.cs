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
    public partial class AltKategori4 : ContentPage
    {
        public AltKategori4()
        {
            InitializeComponent();
        }

        private async void SuClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SuView());
        }

        private async void CayClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CayView());
        }

        private async void KahveClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new KahveView());
        }

        private async void GazozClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GazozView());
        }

        private async void KolaClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new KolaView());
        }

        private async void EnergyDrinkClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EnergyDrinkView());
        }
    }
}