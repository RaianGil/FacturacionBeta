using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Controllers.LocalDB;
using FacaiboBETA.Models;
using SQLite;
using System.Collections.ObjectModel;
using System.Linq;

namespace FacaiboBETA.Controllers
{
    public class loadProductListView
    {
        SQLiteConnection SQLiteConn = cmdConn.getConn();
        ObservableCollection<cbProduct> listProduct = new ObservableCollection<cbProduct>();
        public loadProductListView(string inProductFilter)
        {
            load(inProductFilter);
        }
        public void load(string inProductFilter)
        {
            string strQuery = allQuery.strProductoFilter(inProductFilter);
            var filterProducts = SQLiteConn.Query<Product>(strQuery);
            if (filterProducts.Any())
            {
                foreach (var product in filterProducts)
                    add(product.ProductID, product.ProductDescription);
            }
        }
        public void add(string strProductID, string strProductDesc)
        {
            listProduct.Add(new cbProduct { ProductID = strProductID, ProductDescription = strProductDesc });
        }
        public ObservableCollection<cbProduct> get()
        {
            return listProduct;
        }
    }
}
