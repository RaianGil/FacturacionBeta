using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacaiboBETA.Components.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchProduct
    {
        public SearchProduct()
        {
            InitializeComponent();
            List<String> lstrPrueba = new List<String>();
            lstrPrueba.Add("Prueba100");
            lstrPrueba.Add("Prueba101");
            lstrPrueba.Add("Prueba102");
            lstrPrueba.Add("Prueba103");
            lvProduct.ItemsSource = lstrPrueba;
        }
    }
}