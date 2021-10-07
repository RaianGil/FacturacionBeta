using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace FacaiboBETA.DBManager
{
    class localConn
    {
        public localConn()
        {
        }
        public SQLiteConnection get() 
        {
            return new SQLiteConnection(Preferences.Get("DB_PATH", ""));
        }
    }
}
