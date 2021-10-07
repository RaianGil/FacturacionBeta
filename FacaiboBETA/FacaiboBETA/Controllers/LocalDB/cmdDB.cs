using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace FacaiboBETA.Controllers.LocalDB
{
    public class cmdDB
    {
        public static string getPath()
        {
            return GlobalVar.PathDB();
        }
    }
}
