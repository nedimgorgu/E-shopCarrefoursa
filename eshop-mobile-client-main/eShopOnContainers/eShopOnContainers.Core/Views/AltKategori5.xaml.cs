﻿using eShopOnContainers.Core.ViewModels;
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
            BindingContext = new AltKategori5ViewModel(Navigation);
        }

        

    }
}