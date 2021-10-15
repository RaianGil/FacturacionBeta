using FacaiboBETA.Components.Popup;
using FacaiboBETA.Controllers;
using FacaiboBETA.Controllers.LocalDB;
using FacaiboBETA.Controllers.LocalDB.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacaiboBETA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        bool boShowHide;
        #region MainSetting
        bool boManageInventary;
        bool boMManageProductCode;
        bool boControlBankingEntity;
        bool boControlRNC;
        bool boControlPayMethod;
        bool boControlClientData;
        bool boControlTaxes;
        #endregion
        #region AddProduct Parameters
        string strProductDesc;
        string strCategoryID = "";
        string strProductID = "";
        string strProductCode;
        #endregion
        #region CompanyInfo - Parameters
        string strCompanyName;
        string strCompanyRNC;
        string strCompanyPhone;
        string strCompanyDir;
        #endregion
        public SettingPage()
        {
            InitializeComponent();
            refreshCategoryPicker();
            findProduct();
            InitForm();
            loadParameter();
        }
        #region Control Events
        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnInfo_Clicked(object sender, EventArgs e)
        {
            showInfoPage();
        }
        private void btnPrueba_Clicked(object sender, EventArgs e)
        {
            ShowHide();
        }

        private void entSearchProduct_TextChanged(object sender, TextChangedEventArgs e)
        {
            findProduct();
        }
        private void btnAddCategory_Clicked(object sender, EventArgs e)
        {
            showAddCategory();
            whenPopupClose();
        }
        private void btnCloseCompanyInfo_Clicked(object sender, EventArgs e)
        {
            showCompanyInfoPane(false);
        }
        #endregion
        #region Custom Methods
        private async void ShowHide()
        {
            if (!boShowHide)
            {
                await SettingE.FadeTo(0, 150, Easing.Linear);
                SettingE.IsVisible = false;
                SettingCompanyData.IsVisible = true;
                await SettingCompanyData.FadeTo(1, 150, Easing.Linear);
            }
            else
            {
                await SettingCompanyData.FadeTo(0, 150, Easing.Linear);
                SettingCompanyData.IsVisible = false;
                SettingE.IsVisible = true;
                await SettingE.FadeTo(1, 150, Easing.Linear);
            }
            boShowHide = !boShowHide;
        }

        public void showAddCategory()
        {
            var addCategory = new AddCategory();
            var popAnimation = new PopupAnimation();
            GlobalVar.OpenPopup(true);
            popAnimation.ShowHorizontal(addCategory);
        }
        private void refreshCategoryPicker()
        {
            var listCategory = new loadCategoryPicker();
            pkCategory.ItemsSource = listCategory.get();
        }

        private void whenPopupClose()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (!GlobalVar.OpenPopup())
                {
                    refreshCategoryPicker();
                    return false;
                }
                return true;
            });
        }
        private void findProduct()
        {
            var load = new loadProductListView(entSearchProduct.Text);
            lvFilterProduct.ItemsSource = load.get();
        }
        private void showInfoPage()
        {
            var infoPage = new InfoPopup();
            var popAnimation = new PopupAnimation();
            GlobalVar.OpenPopup(true);
            popAnimation.ShowHorizontal(infoPage);
        }
        private async void showCompanyInfoPane(bool boShow)
        {
            if (boShow)
            {
                await SettingE.FadeTo(0, 150, Easing.Linear);
                SettingE.IsVisible = false;
                SettingCompanyData.IsVisible = true;
                await SettingCompanyData.FadeTo(1, 150, Easing.Linear);
            }
            else
            {
                await SettingCompanyData.FadeTo(0, 150, Easing.Linear);
                SettingCompanyData.IsVisible = false;
                SettingE.IsVisible = true;
                await SettingE.FadeTo(1, 150, Easing.Linear);
            }
        }
        private async void showProductListPane(bool boShow)
        {
            if (boShow)
            {
                await SettingE.FadeTo(0, 150, Easing.Linear);
                SettingE.IsVisible = false;
                SettingProductList.IsVisible = true;
                await SettingProductList.FadeTo(1, 150, Easing.Linear);
            }
            else
            {
                await SettingProductList.FadeTo(0, 150, Easing.Linear);
                SettingProductList.IsVisible = false;
                SettingE.IsVisible = true;
                await SettingE.FadeTo(1, 150, Easing.Linear);
            }
        }
        private async void showProductPane(bool boShow)
        {
            if (boShow)
            {
                await SettingE.FadeTo(0, 150, Easing.Linear);
                SettingE.IsVisible = false;
                SettingProduct.IsVisible = true;
                await SettingProduct.FadeTo(1, 150, Easing.Linear);
            }
            else
            {
                await SettingProduct.FadeTo(0, 150, Easing.Linear);
                SettingProduct.IsVisible = false;
                SettingE.IsVisible = true;
                await SettingE.FadeTo(1, 150, Easing.Linear);
            }
        }
        private void loadAddProduct()
        {
            strProductDesc = entProductName.Text;
            strProductCode = entProductCode.Text;
        }
        private void InitForm()
        {
            entProductName.Text = "";
            entProductCode.Text = "";
            pkCategory.SelectedItem = 0;
            //
            strCategoryID = "";
        }
        private void loadMainSetting()
        {
            boManageInventary = swManageInventary.IsToggled;
            boMManageProductCode = swManageProductCode.IsToggled;
            boControlBankingEntity = swControlBankingEntity.IsToggled;
            boControlRNC = swControlRNC.IsToggled;
            boControlPayMethod = swControlPayMethod.IsToggled;
            boControlClientData = swControlClientData.IsToggled;
            boControlTaxes = swControlTaxes.IsToggled;
        }
        private void loadCompanyInfo()
        {
            strCompanyName = entCompanyName.Text;
            strCompanyRNC = entCompanyRNC.Text;
            strCompanyPhone = entCompanyPhone.Text;
            strCompanyDir = entCompanyDir.Text;
        }
        private void saveCompanyInfo()
        {
            var companyInfo = new CompanyInfoIU()
            {
                CompanyName = strCompanyName,
                CompanyRNC = strCompanyRNC,
                CompanyPhone = strCompanyPhone,
                CompanyDirection = strCompanyDir
            };
            companyInfo.save();
        }
        private void saveMainSetting()
        {
            loadMainSetting();

        }
        private void loadParameter()
        {
            var mainSetting = GetData.Setting();
            swManageInventary.IsToggled = mainSetting.boManageInventary;
            swManageProductCode.IsToggled = mainSetting.boManageProductCode;
            swControlBankingEntity.IsToggled = mainSetting.boControlBankingEntity;
            swControlRNC.IsToggled = mainSetting.boControlRNC;
            swControlPayMethod.IsToggled = mainSetting.boControlPayMethod;
            swControlClientData.IsToggled = mainSetting.boControlClientData;
            swControlTaxes.IsToggled = mainSetting.boControlTaxes;

            var companyInfo = GetData.CompanyInfo();
            entCompanyName.Text = companyInfo.CompanyName;
            entCompanyRNC.Text = companyInfo.CompanyRNC;
            entCompanyDir.Text = companyInfo.CompanyDirection;
            entCompanyPhone.Text = companyInfo.CompanyPhone;
        }
        private bool checkDataProduct()
        {
            if(entProductName.Text == "")
            {
                entProductName.Focus();
                return false;
            }

            if(strCategoryID == "")
            {
                pkCategory.Focus();
                return false;
            }
            return true;
        }
        #endregion

        private void btnAddProduct_Clicked(object sender, EventArgs e)
        {
            showProductPane(true);
        }

        private void btnCloseAddProduct_Clicked(object sender, EventArgs e)
        {
            showProductPane(false);
        }

        private void btnCloseList_Clicked(object sender, EventArgs e)
        {
            showProductListPane(false);
        }

        private void btnShowProductList_Clicked(object sender, EventArgs e)
        {
            showProductListPane(true);
        }

        private void btnShowCompanyInfo_Clicked(object sender, EventArgs e)
        {
            showCompanyInfoPane(true);
        }

        private void pkCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pkCategory.SelectedIndex != -1)
            {
                var getID = new getComboID();
                strCategoryID = getID.Category(pkCategory);
            }
        }

        private void btnSaveProduct_Clicked(object sender, EventArgs e)
        {
            if (checkDataProduct())
            {
                loadAddProduct();
                var insertProduct = new ProductIU();
                insertProduct.CategoryID = strCategoryID;
                insertProduct.ProductDescription = strProductDesc;
                insertProduct.save();
                InitForm();
            }
        }

        private void lvFilterProduct_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var getID = new getComboID();
            strProductID = getID.lvProduct(lvFilterProduct);
            Terminal.show(strProductID);
        }

        private void btnSaveCompanyInfo_Clicked(object sender, EventArgs e)
        {
            loadCompanyInfo();
            saveCompanyInfo();
        }

        private void btnDropProduct_Clicked(object sender, EventArgs e)
        {
            if(strProductID != "")
            {
                ProductIU.drop(strProductID);
                findProduct();
            }
                
        }

        private void btnModifyProduct_Clicked(object sender, EventArgs e)
        {

        }
    }
}