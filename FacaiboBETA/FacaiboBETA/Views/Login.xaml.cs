using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FacaiboBETA.Controllers;
using FacaiboBETA.Controllers.Admin;

namespace FacaiboBETA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        string username;
        string password;
        bool boRemeberUser;
        private void btnAccesar_Clicked(object sender, System.EventArgs e)
        {
            verifyLogin();
        }
 
        
        public Login()
        {
            InitializeComponent();
            checkRemeberAcount();
        }
        public void verifyLogin() 
        {
            var Log = loadData();
            if (Log.check(username, password))
            {
                successLog();
            }
            else
            {
                failLog();
            }
        }
        public void failLog() 
        {
            var addUser = new createUser();
            addUser.run(username, password);
            lblErrorMSG.Text = "Usuario/Clave Incorrecto";
            lblErrorMSG.IsVisible = true;
        }
        public void successLog()
        {
            if (username != null)
                saveInSetting();
            Navigation.PushAsync(new SettingPage());
        }
        public AppLogin loadData()
        {
            username = entUsername.Text;
            password = entPassword.Text;
            boRemeberUser = swRemenberAcount.IsToggled;
            lblErrorMSG.IsVisible = false;
            return new AppLogin();
        }
        private void saveInSetting() 
        {
            var appConfig = new AppConfig();
            appConfig.saveSetting(username, boRemeberUser);
        }
        private void entPassword_Completed(object sender, System.EventArgs e)
        {
            verifyLogin();
        }
        private void checkRemeberAcount() 
        {
            if(AppConfig.loadRemenberAcount())
            {
                successLog();
            }
        }

        private void entUsername_Completed(object sender, System.EventArgs e)
        {
            entPassword.Focus();
        }
    }
}