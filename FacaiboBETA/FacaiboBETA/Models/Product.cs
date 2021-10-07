using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Models
{
    public class Product
    {
        [PrimaryKey]
        public string ProductID { get; set; }
        public string CategoryID { get; set; }
        public string ProductDescription { get; set; }
    }
}
