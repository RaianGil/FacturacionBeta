using FacaiboBETA.Components.Popup;
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
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnInfo_Clicked(object sender, EventArgs e)
        {
            showInfoPage();
        }
        private void showInfoPage()
        {
            var infoPage = new InfoPopup();
            var popAnimation = new PopupAnimation();
            GlobalVar.OpenPopup(true);
            popAnimation.ShowHorizontal(infoPage);
        }
    }
}