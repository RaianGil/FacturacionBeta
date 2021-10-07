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
    public partial class AddClient
    {
        string strClientName;
        string strClientRNC;
        string strClientDir;
        string strContactName;
        string strContactNumber;
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnSaveExit_Clicked(object sender, EventArgs e)
        {
            loadParameter();
            if (!checkNull())
            {
                saveClient();
                closePopup();
            }
        }

        private void closePopup()
        {
            PopupAnimation.ClosePopup();
        }
        private void saveClient()
        {
            var saveClient = new ClientIU()
            {
                ClientName = strClientName,
                ClientRNC = strClientRNC
            };
            saveClient.save();
        }
        private void loadParameter()
        {
            strClientName = entClientName.Text;
            strClientRNC = entClientRFiscal.Text;
            strContactName = entContactName.Text;
            strContactNumber = entClientPhoneNumber.Text;
        }
        private bool checkNull()
        {
            if (strClientName == "" || strClientRNC == "")
                return true;
            return false;
        }
    }
}