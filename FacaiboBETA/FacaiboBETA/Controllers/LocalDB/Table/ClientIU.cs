using System;
using System.Linq;
using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Models;
using SQLite;

namespace FacaiboBETA.Controllers.LocalDB.Table
{
    public class ClientIU : Client
    {
        static SQLiteConnection SQLiteConn = cmdConn.getConn();
        public string ClientDir { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public ClientIU()
        {
        }
        public string save()
        {
            var findUser = SQLiteConn.Query<Client>($"SELECT * FROM Client WHERE ClientName = '{this.ClientName}' or ClientRNC = '{this.ClientRNC}'");
            if (!findUser.Any())
                return insert();
                
            return findUser.First().ClientID;
        }
        public string insert()
        {
            Client insertClient = new Client();
            insertClient.ClientID = Guid.NewGuid().ToString();
            insertClient.ClientName = this.ClientName.Trim().ToUpper();
            insertClient.ClientRNC = this.ClientRNC.Trim().ToUpper();
            SQLiteConn.Insert(insertClient);

            return insertClient.ClientID;
        }
        public void update(Client inClient)
        {
            var updateClient = new Client();
            updateClient.ClientID = inClient.ClientID;
            updateClient.ClientName = this.ClientName;
        }
    }
}
