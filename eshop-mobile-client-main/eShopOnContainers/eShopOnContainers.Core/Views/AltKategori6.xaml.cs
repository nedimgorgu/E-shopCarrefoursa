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
    public partial class AltKategori6 : ContentPage
    {
        public AltKategori6()
        {
            InitializeComponent();
            BindingContext = new AltKategori6ViewModel(Navigation);
        }

        
    }
}