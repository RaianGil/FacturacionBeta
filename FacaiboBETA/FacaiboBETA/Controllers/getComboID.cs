using FacaiboBETA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FacaiboBETA.Controllers
{
    class getComboID
    {
        cbCategory outCategory;
        cbClient outClient;
        cbProduct outProduct;

        public getComboID()
        {
            outCategory = new cbCategory();
            outProduct = new cbProduct();
            outClient = new cbClient();
        }

        public string Category(Picker inCategoryPicker)
        {
            outCategory = (cbCategory)inCategoryPicker.SelectedItem;
            return outCategory.CategoryID;
        }

        public string Client(Picker inClientPicker)
        {
            outClient = (cbClient)inClientPicker.SelectedItem;
            return outClient.ClientID;
        }

        public string lvProduct(ListView inCProductListBox)
        {
            outProduct = (cbProduct)inCProductListBox.SelectedItem;
            return outProduct.ProductID;
        }
    }
}
