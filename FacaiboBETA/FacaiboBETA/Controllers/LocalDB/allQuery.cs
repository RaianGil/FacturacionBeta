using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Controllers.LocalDB
{
    public class allQuery
    {
        public static string strProductAll = "SELECT * FROM Product";
        public static string strClientAll = "SELECT * FROM Client";
        public static string strCategoryAll = "SELECT * FROM Category";
        public static string strProductoFilter(string inProductFind)
        {
            return $"SELECT * FROM Product WHERE ProductDescription Like '%{inProductFind}%'";
        }
    }
}
