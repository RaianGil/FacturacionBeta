using FacaiboBETA.DBManager;
using FacaiboBETA.Models;
using System.Linq;

namespace FacaiboBETA.Controllers
{
    public class AppLogin
    {
        public AppLogin()
        {
        }
        public bool check(string inUsername, string inPassword) 
        {
            bool boReturn = false;
            var localConn = new localConn();
            var SQLiteConn = localConn.get();
            inUsername = inUsername.Replace("'", "");
            inPassword = inPassword.Replace("'", "");
            var checkUser = SQLiteConn.Query<User>($"SELECT * FROM User WHERE strUsername = '{inUsername}' and strPassword = '{inPassword}'");

            if (checkUser.Any())
                boReturn = true;
            return boReturn;
        }
    }
}
