using FacaiboBETA.Controllers;
using FacaiboBETA.Controllers.LocalDB.Table;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
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
    public partial class InfoPopup
    {
        public InfoPopup()
        {
            InitializeComponent();
        }

        private void btnClosePopup_Clicked(object sender, EventArgs e)
        {
            PopupAnimation.ClosePopup();
        }
    }
}