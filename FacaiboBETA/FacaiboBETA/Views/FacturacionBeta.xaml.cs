using FacaiboBETA.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacaiboBETA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacturacionBeta : ContentPage
    {
        List<String> lstrPrueba = new List<String>();
        public FacturacionBeta()
        {
            InitializeComponent();
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            eventLeftMenu.show();
        }

        private void btnMenu_Clicked(object sender, EventArgs e)
        {
            eventLeftMenu.show();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            lstrPrueba.Add("Prueba100");
            lstrPrueba.Add("Prueba101");
            lstrPrueba.Add("Prueba102");
            lstrPrueba.Add("Prueba103");
            lvPrueba1.ItemsSource = lstrPrueba;
        }
    }
}