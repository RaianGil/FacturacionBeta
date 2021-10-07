using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Controllers.LocalDB;
using FacaiboBETA.Models;
using SQLite;
using System.Collections.ObjectModel;
using System.Linq;

namespace FacaiboBETA.Controllers
{
    public class loadClientPicker
    {
        SQLiteConnection SQLiteConn = cmdConn.getConn();
        ObservableCollection<cbClient> listClient = new ObservableCollection<cbClient>();
        public loadClientPicker()
        {
            load();
        }
        public void load()
        {
            var allClient = SQLiteConn.Query<Client>(allQuery.strClientAll);
            if (allClient.Any())
            {
                foreach (var Client in allClient)
                    add(Client.ClientID, Client.ClientName);
            }
        }
        public void add(string strClientID, string strClientDesc)
        {
            listClient.Add(new cbClient { ClientID = strClientID, ClientName = strClientDesc });
        }
        public ObservableCollection<cbClient> get() 
        {
            return listClient;
        }
    }
}
