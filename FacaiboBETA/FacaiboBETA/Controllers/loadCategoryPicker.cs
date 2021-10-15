using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Controllers.LocalDB;
using FacaiboBETA.Models;
using SQLite;
using System.Collections.ObjectModel;
using System.Linq;

namespace FacaiboBETA.Controllers
{
    public class loadCategoryPicker
    {
        SQLiteConnection SQLiteConn = cmdConn.getConn();
        ObservableCollection<cbCategory> listCategory = new ObservableCollection<cbCategory>();
        public loadCategoryPicker()
        {
            load();
        }
        public void load()
        {
            var allCategory = SQLiteConn.Query<Category>(allQuery.strCategoryAll);
            if (allCategory.Any())
            {
                foreach (var Category in allCategory)
                    add(Category.CategoryID, Category.CategoryDescription);
            }
        }
        public void add(string strCategoryID, string strCategoryDesc)
        {
            listCategory.Add(new cbCategory { CategoryID = strCategoryID, CategoryName = strCategoryDesc });
        }
        public ObservableCollection<cbCategory> get() 
        {
            return listCategory;
        }
    }
}
