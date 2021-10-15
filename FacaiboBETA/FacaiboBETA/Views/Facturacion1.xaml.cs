using FacaiboBETA.Components;
using FacaiboBETA.Components.Popup;
using FacaiboBETA.Controllers;
using FacaiboBETA.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacaiboBETA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Facturacion1 : ContentPage
    {
        int intCount = 0;
        public Facturacion1()
        {
            InitializeComponent();
            MyItems = new ObservableCollection<MyItem>();
            MyItems.Add(new MyItem() { Producto = "Producto Prueba", Cantidad = 1, Precio = 70 });
            MyItems.Add(new MyItem() { Producto = "Producto Prueba 2", Cantidad = 4, Precio = 70 });
            MyItems.Add(new MyItem() { Producto = "Producto Prueba 3", Cantidad = 4, Precio = 70 });
            lvFactura.ItemsSource = MyItems;
            refreshClient();
        }
        private void btnMenu_Clicked(object sender, EventArgs e)
        {
            eventLeftMenu.show();
        }

        private ObservableCollection<MyItem> MyItems { get; set; }

        private void btnPruebaStanley_Clicked(object sender, EventArgs e)
        {
            intCount++;
            MyItems.Add(new MyItem() { Producto = $"Producto Agregado {intCount}", Cantidad = 4, Precio = 70 });

        }

        private void btnAddClient_Clicked(object sender, EventArgs e)
        {
            showAddClient();
        }

        private void picClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var inPedra = new cbClient();
            inPedra = (cbClient) picClientName.SelectedItem;
            Debug.WriteLine(inPedra.ClientID);
        }
        private void btnSetting_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());
        }
        private void btnSearchProduct_Clicked(object sender, EventArgs e)
        {
            showSearchProduct();
        }
        private void PTimer()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (!GlobalVar.OpenPopup())
                {
                    refreshClient();
                    return false;
                }
                return true;
            });
        }
        public async void showAddClient()
        {
            var addClientP = new AddClient();
            var popAnimation = new PopupAnimation();
            GlobalVar.OpenPopup(true);
            popAnimation.ShowHorizontal(addClientP);
            PTimer();
        }
        public void refreshClient()
        {
            var lsClient = new loadClientPicker();
            picClientName.ItemsSource = lsClient.get();
            Debug.WriteLine("Client Refresh");
        }
        public async void showSearchProduct()
        {
            var searchProduct = new SearchProduct();
            var popAnimation = new PopupAnimation();
            GlobalVar.OpenPopup(true);
            popAnimation.ShowHorizontal(searchProduct);
        }

    }
}