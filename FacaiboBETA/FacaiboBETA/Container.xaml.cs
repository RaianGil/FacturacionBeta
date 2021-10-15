using FacaiboBETA.Components;
using FacaiboBETA.Controllers;
using FacaiboBETA.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacaiboBETA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Container : MasterDetailPage
    {
        bool showLeftMenu;
        public Container()
        {
            InitializeComponent();
            this.Master = new LeftMenu();
            this.Detail = new NavigationPage(new MainPage());
            eventLeftMenu.inContainer = this;


        }
        public void showMenu() 
        {
            showLeftMenu = !showLeftMenu;
            this.IsPresented = showLeftMenu;
        }
    }
}