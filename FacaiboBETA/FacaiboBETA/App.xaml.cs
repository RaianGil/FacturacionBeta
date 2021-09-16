using FacaiboBETA.Views;
using Microsoft.Data.Sqlite;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacaiboBETA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
            /*//Crear string para la base de datos
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "dbFact.db");

            //Guardamos el string de la base de datos en una preferencia.
            Preferences.Set("DB_PATH", dbPath);

            //Setiamos la Version
            Preferences.Set("VERSION", "3.0.0.1.1");

            //Conectar con la base de datos
            var db = new SqliteConnection(dbPath);*/

            //db.CreateTable<OptionsIn>();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
