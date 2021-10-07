using FacaiboBETA.Controllers.LocalDB;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacaiboBETA.Controllers.LocalConn
{
    public class cmdConn
    {

        public static SQLiteConnection getConn()
        {
            return new SQLiteConnection(cmdDB.getPath());
        }
    }
}
