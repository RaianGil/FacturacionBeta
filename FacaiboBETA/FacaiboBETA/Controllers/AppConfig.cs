using FacaiboBETA.Models;
using FacaiboBETA.DBManager;
using System.Linq;
using System;
using FacaiboBETA.Controllers.Admin;

namespace FacaiboBETA.Controllers
{
    public class AppConfig
    {
        public void saveSetting(string inUsername, bool inRemenbeAcount)
        {
            var localConn = new localConn();
            var SQLiteConn = localConn.get();
            var anyAppConfig = SQLiteConn.Query<Setting>("SELECT * FROM Setting where intConfigID = 1");

            if (anyAppConfig.Any())
            {
                var updateConfig = new Setting();
                updateConfig.intConfigID = 1;
                updateConfig.strUsername = inUsername;
                updateConfig.boRemenberAcount = inRemenbeAcount;
                SQLiteConn.Update(updateConfig);
            }
            else
            {
                var newConfig = new Setting();
                newConfig.intConfigID = 1;
                newConfig.strUsername = inUsername;
                newConfig.boRemenberAcount = inRemenbeAcount;
                SQLiteConn.Insert(newConfig);
            }
        }

        public static bool loadRemenberAcount() 
        {
            var localConn = new localConn();
            var SQLiteConn = localConn.get();
            try
            {
                var setting = SQLiteConn.Query<Setting>("SELECT * FROM Setting where intConfigID = 1");
                if (setting.Any())
                    return setting.First().boRemenberAcount;
            }
            catch(Exception e) 
            {
                _ = new createTableSetting();
            }
            return false;

        }
    }
}
