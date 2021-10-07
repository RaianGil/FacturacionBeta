using FacaiboBETA.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Controllers
{
    public class eventLeftMenu
    {
        public static Container inContainer;
        public eventLeftMenu()
        {

        }
        public static void show() 
        {
            inContainer.IsPresented = true;
        }
        public static void hide()
        {
            inContainer.IsPresented = false;
        }
    }
}
