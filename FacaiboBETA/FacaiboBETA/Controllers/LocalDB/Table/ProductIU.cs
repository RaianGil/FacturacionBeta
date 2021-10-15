using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Models;
using SQLite;
using System;
using System.Linq;

namespace FacaiboBETA.Controllers.LocalDB.Table
{
    class ProductIU : Product
    {
        static SQLiteConnection SQLiteConn = cmdConn.getConn();
        public ProductIU()
        {
        }
        public string save()
        {
            var findProduct = SQLiteConn.Query<Product>($"SELECT * FROM Product WHERE ProductDescription = '{this.ProductDescription.ToUpper()}'");
            if (!findProduct.Any())
                return insert();
            else
                Toast.Show("Esta Producto ya Existe!");

            return findProduct.First().ProductID;
        }
        public string insert()
        {
            Product insertProduct = new Product();
            insertProduct.ProductID = Guid.NewGuid().ToString();
            insertProduct.CategoryID = this.CategoryID;
            insertProduct.ProductDescription = this.ProductDescription.Trim().ToUpper();
            SQLiteConn.Insert(insertProduct);
            Toast.Show("Producto Creado!");

            return insertProduct.ProductID;
        }
        public static void drop(string inProductID)
        {
            var findProduct = SQLiteConn.Query<Product>($"SELECT * FROM Product WHERE ProductID = '{inProductID}'");
            if (findProduct.Any())
            {
                SQLiteConn.Delete(findProduct.First());
                Toast.Show("Producto Borrado Exitosamente!");
            }
        }
    }
}
