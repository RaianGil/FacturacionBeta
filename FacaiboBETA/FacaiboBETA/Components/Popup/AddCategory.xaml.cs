using FacaiboBETA.Controllers;
using FacaiboBETA.Controllers.LocalDB.Table;
using FacaiboBETA.Models;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacaiboBETA.Components.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCategory
    {
        string strCategoryName;
        public AddCategory()
        {
            InitializeComponent();
        }
        private void entCategory_Completed(object sender, EventArgs e)
        {
            createCategory();
        }
        private void loadCategory()
        {
            strCategoryName = entCategory.Text;
        }
        private void createCategory()
        {
            loadCategory();
            var newCategory = new CategoryIU();
            newCategory.CategoryDescription = strCategoryName;
            newCategory.save();
            Close();
        }
        private void Close()
        {
            PopupAnimation.ClosePopup();
        }
        private void init()
        {
            entCategory.Text = "";
            entCategory.Focus();
        }
    }
}