using FacaiboBETA.DBManager;
using FacaiboBETA.Models;

namespace FacaiboBETA.Controllers.Admin
{
    class createTableSetting
    {
        public createTableSetting()
        {
            var localConn = new localConn();
            var SQLiteConn = localConn.get();
            SQLiteConn.CreateTable<Setting>();
        }
    }
}
