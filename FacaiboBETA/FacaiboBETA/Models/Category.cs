using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Models
{
    public class Category
    {
        [PrimaryKey]
        public string CategoryID { get; set; }
        public string CategoryDescription { get; set; }
    }
}
