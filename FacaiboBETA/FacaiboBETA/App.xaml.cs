using FacaiboBETA.Controllers;
using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Controllers.LocalDB;
using FacaiboBETA.Models;
using FacaiboBETA.Views;
using SQLite;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace FacaiboBETA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var appEvent = new AppEvent();
            MainPage = appEvent.OpenXaml();
        }

        protected override void OnStart()
        {
            //Creating db
            _ = new createDB();
            //Creando tablas
            createTable.All();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
