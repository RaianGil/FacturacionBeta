
using SQLite;

namespace FacaiboBETA.Models
{
    public class Client
    {
        [PrimaryKey]
        public string ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientRNC { get; set; }
    }
}
