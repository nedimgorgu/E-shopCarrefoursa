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
    public partial class AltKategori6 : ContentPage
    {
        public AltKategori6()
        {
            InitializeComponent();
        }

        private async void BebekBeziClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BebekBeziView());
        }

        private async void IslakHavluClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new IslakHavluView());
        }

        private async void BebekSampuaniClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BebekSampuaniView());
        }
    }
}