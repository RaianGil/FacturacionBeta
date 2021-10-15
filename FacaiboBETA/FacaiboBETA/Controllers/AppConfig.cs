using FacaiboBETA.Models;
using FacaiboBETA.DBManager;
using System.Linq;
using System;
using FacaiboBETA.Controllers.Admin;
using FacaiboBETA.Controllers.LocalDB.Table;
using SQLite;
using FacaiboBETA.Controllers.LocalConn;

namespace FacaiboBETA.Controllers
{
    public class AppConfig
    {
        static SQLiteConnection SQLiteConn = cmdConn.getConn();
        public void saveSetting(string inUsername, bool inRemenbeAcount)
        {
            var saveSetting = new SettingIU();
            saveSetting._boRemenberAcount = inRemenbeAcount;
            saveSetting.strUsername = inUsername;
            saveSetting.save();
        }

        public static bool loadRemenberAcount() 
        {
            try
            {
                var setting = SQLiteConn.Query<Setting>("SELECT * FROM Setting");
                string strUserLog = setting.First().strUsername.ToString();
                if (setting.Any() && strUserLog != "")
                {
                    GlobalVar.UserLog(strUserLog);
                    return Convert.ToBoolean(setting.First().boRemenberAcount);
                }
            }
            catch(Exception e) 
            {
                //_ = new createTableSetting();
            }
            return false;
        }
    }
}
