using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Models;
using SQLite;

namespace FacaiboBETA.Controllers.LocalDB
{
    public class createTable
    {
        static SQLiteConnection SQLiteConn = cmdConn.getConn();
        public static void All()
        {
            User();
            Setting();
            Category();
            Product();
            Client();
            Contact();
        }

        public static void User()
        {
            SQLiteConn.CreateTable<User>();
        }
        public static void Setting()
        {
            SQLiteConn.CreateTable<Setting>();
        }
        public static void Category()
        {
            SQLiteConn.CreateTable<Category>();
        }
        public static void Product()
        {
            SQLiteConn.CreateTable<Product>();
        }
        public static void Client()
        {
            SQLiteConn.CreateTable<Client>();
        }
        public static void Contact()
        {
            SQLiteConn.CreateTable<infoClient>();
        }
    }
}
