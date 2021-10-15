using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Controllers
{
    class checkData
    {
        public static bool str(string inData) //CheckData string
        {
            if (inData == "" || inData == null)
                return false;
            return true;
        }

        public static bool bo(bool? inData) //CheckData bool
        {
            if (inData == null)
                return false;
            return true;
        }
    }
}
