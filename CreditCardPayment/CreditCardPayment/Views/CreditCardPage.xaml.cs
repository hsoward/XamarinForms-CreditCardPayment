using System;
using System.Collections.Generic;
using System.ComponentModel;
using CreditCardPayment.ViewModels;
using Xamarin.Forms;

namespace CreditCardPayment.Views
{
    [DesignTimeVisible(false)]
    public partial class CreditCardPage : ContentPage
    {
        public CreditCardPage()
        {
            InitializeComponent();
            this.BindingContext = new CreditCardPageViewModel();
        }
    }
}
