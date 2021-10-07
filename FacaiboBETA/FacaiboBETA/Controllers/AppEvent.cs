using FacaiboBETA.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FacaiboBETA.Controllers
{
    class AppEvent
    {
        private bool boRemeberUser;
        public AppEvent()
        {

        }

        public NavigationPage OpenXaml() 
        {
            if (!boRemeberUser)
                return new NavigationPage(new Login());
            else
                return new NavigationPage(new SettingPage());
        }
    }
}
