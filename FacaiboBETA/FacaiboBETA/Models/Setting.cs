using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Models
{
    public class Setting
    {
        [PrimaryKey]
        public int intConfigID { get; set; }
        public string strUsername { get; set; }
        public bool boRemenberAcount { get; set; }
    }
}
