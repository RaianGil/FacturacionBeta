using System;
using System.IO;
using Xamarin.Essentials;

namespace FacaiboBETA.Controllers.LocalDB
{
    public class createDB
    {
        public createDB()
        {
            //Creando base de datos
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), $"{propertiesDB.nameDB()}.db");

            //Guardamos el string de la base de datos en una preferencia.
            GlobalVar.PathDB(dbPath);
        }
    }
}
