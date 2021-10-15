using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Models;
using SQLite;
using System;
using System.Linq;

namespace FacaiboBETA.Controllers.LocalDB.Table
{
    class CategoryIU : Category
    {
        static SQLiteConnection SQLiteConn = cmdConn.getConn();
        public CategoryIU()
        {
        }
        public string save()
        {
            var findCategory = SQLiteConn.Query<Category>($"SELECT * FROM Category WHERE CategoryDescription = '{this.CategoryDescription}'");
            if (!findCategory.Any())
                return insert();
            else
                Toast.Show("Esta Categoria ya Existe!");

            return findCategory.First().CategoryID;
        }
        public string insert()
        {
            Category insertCategory = new Category();
            insertCategory.CategoryID = Guid.NewGuid().ToString();
            insertCategory.CategoryDescription = this.CategoryDescription.Trim().ToUpper();
            SQLiteConn.Insert(insertCategory);
            Toast.Show("Categoria Creada!");

            return insertCategory.CategoryID;
        }
    }
}
