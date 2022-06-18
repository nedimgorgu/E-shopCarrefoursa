using eShopOnContainers.Core.ViewModels;
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
            BindingContext = new AltKategori3ViewModel(Navigation);
        }

        

    }
}