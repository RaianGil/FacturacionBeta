using FacaiboBETA.Controllers;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacaiboBETA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Facturacion : ContentPage
    {
        public Facturacion()
        {
            InitializeComponent();
        }
        private void btnMenu_Clicked(object sender, EventArgs e)
        {
            eventLeftMenu.show();
        }
    }
}