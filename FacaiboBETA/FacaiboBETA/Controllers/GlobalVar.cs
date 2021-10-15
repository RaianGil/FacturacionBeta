using Xamarin.Essentials;

namespace FacaiboBETA.Controllers
{
    public class GlobalVar
    {
        public static string PathDB()
        {
            //Get DB_PATH
            return Preferences.Get("DB_PATH","");
        }
        public static void PathDB(string inPath) 
        {
            //Set DB_PATH
            Preferences.Set("DB_PATH", inPath);
        }
        public static string UserLog()
        {
            //Get USER_LOG
            return Preferences.Get("USER_LOG", "");
        }
        public static void UserLog(string inUserLog)
        {
            //Get USER_LOG
            Preferences.Set("USER_LOG", inUserLog);
        }
        public static bool OpenPopup()
        {
            //Get OPEN_POPUP
            return Preferences.Get("OPEN_POPUP", false);
        }
        public static void OpenPopup(bool inIsOpen)
        {
            //Get OPEN_POPUP
            Preferences.Set("OPEN_POPUP", inIsOpen);
        }
    }
}
