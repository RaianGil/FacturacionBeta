using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Models
{
    public class User
    {
        [PrimaryKey]
        public string strUsername { get; set; }
        public string strPassword { get; set; }
        public DateTime tsLastConnect { get; set; }
    }
}
