using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Models
{
    public class CompanyInfo
    {
        [PrimaryKey]
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyRNC { get; set; }
        public string CompanyDirection { get; set; }
        public string CompanyPhone { get; set; }
    }
}
