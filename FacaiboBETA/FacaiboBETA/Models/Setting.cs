using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Models
{
    public class Setting
    {
        [PrimaryKey]
        public string strSettingID { get; set; }
        public string strUsername { get; set; }
        public bool boRemenberAcount { get; set; }
        public bool boManageInventary { get; set; }
        public bool boManageProductCode { get; set; }
        public bool boControlBankingEntity { get; set; }
        public bool boControlRNC { get; set; }
        public bool boControlPayMethod { get; set; }
        public bool boControlClientData { get; set; }
        public bool boControlTaxes { get; set; }
    }
}
