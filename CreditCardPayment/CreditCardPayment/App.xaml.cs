using System;
using CreditCardPayment.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CreditCardPayment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNavigationPage(new CreditCardPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
