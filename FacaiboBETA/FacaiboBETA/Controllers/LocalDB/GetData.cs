using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Models;
using SQLite;
using System.Linq;

namespace FacaiboBETA.Controllers.LocalDB
{
    public class GetData
    {
        static SQLiteConnection SQLiteConn = cmdConn.getConn();
        public static CompanyInfo CompanyInfo() 
        {
            var CompanyOut = SQLiteConn.Query<CompanyInfo>($"SELECT * FROM CompanyInfo");
            if(CompanyOut.Any())
                return SQLiteConn.Query<CompanyInfo>($"SELECT * FROM CompanyInfo").First();

            return new CompanyInfo();
        }

        public static Setting Setting()
        {
            var SettingOut = SQLiteConn.Query<Setting>($"SELECT * FROM Setting");
            if(SettingOut.Any())    
                return SQLiteConn.Query<Setting>($"SELECT * FROM Setting").First();
            
            return new Setting();
        }
    }
}
