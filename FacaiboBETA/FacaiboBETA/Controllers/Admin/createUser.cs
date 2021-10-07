using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using FacaiboBETA.DBManager;
using FacaiboBETA.Models;

namespace FacaiboBETA.Controllers.Admin
{
    class createUser
    {
        public createUser()
        {
        }
        public bool run(string inUsername, string inPassword) 
        {
            bool boOutput = false;
            try
            {
                var inUser = new User();
                inPassword = inPassword.Replace("'", "");
                inUsername = inUsername.Replace("'", "");
                inUser.strUsername = inUsername;
                inUser.strPassword = inPassword;
                inUser.tsLastConnect = DateTime.Today;
                var localConn = new localConn();
                var SQLiteConn = localConn.get();
                SQLiteConn.Insert(inUser);
                boOutput = true;

            }
            catch(Exception e)
            {
                Debug.WriteLine($"No se pudo crear el Usuario: {e}");
            }
            return boOutput;
        }
    }
}
