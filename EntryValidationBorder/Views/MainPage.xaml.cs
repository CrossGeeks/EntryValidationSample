using System;
using System.Collections.Generic;
using EntryValidationBorder.ViewModels;
using Xamarin.Forms;

namespace EntryValidationBorder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
