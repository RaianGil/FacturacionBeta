using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacaiboBETA.Controllers.LocalDB.Table
{
    public class CompanyInfoIU : CompanyInfo
    {
        static SQLiteConnection SQLiteConn = cmdConn.getConn();

        public CompanyInfoIU()
        {
        }
        public string save()
        {
            var findUser = SQLiteConn.Query<CompanyInfo>($"SELECT * FROM CompanyInfo");
            if (!findUser.Any())
                return insert();

            return update(findUser.First());
        }
        public string insert()
        {
            CompanyInfo insertCompanyInfo = new CompanyInfo();
            insertCompanyInfo.CompanyID = Guid.NewGuid().ToString();
            insertCompanyInfo.CompanyName = this.CompanyName.Trim().ToUpper();
            insertCompanyInfo.CompanyRNC = this.CompanyRNC.Trim().ToUpper();
            insertCompanyInfo.CompanyDirection = this.CompanyDirection.Trim().ToUpper();
            insertCompanyInfo.CompanyPhone = this.CompanyPhone.Trim().ToUpper();
            SQLiteConn.Insert(insertCompanyInfo);
            
            Toast.Show("Datos Guardados Correctamente!");
            return insertCompanyInfo.CompanyID;
        }
        public string update(CompanyInfo inCompanyInfo)
        {
            var updateCompanyInfo = new CompanyInfo();
            updateCompanyInfo.CompanyID = inCompanyInfo.CompanyID;
            updateCompanyInfo.CompanyName = this.CompanyName.Trim().ToUpper();
            updateCompanyInfo.CompanyRNC = this.CompanyRNC.Trim().ToUpper();
            updateCompanyInfo.CompanyDirection = this.CompanyDirection.Trim().ToUpper();
            updateCompanyInfo.CompanyPhone = this.CompanyPhone.Trim().ToUpper();
            SQLiteConn.Update(updateCompanyInfo);
            
            Toast.Show("Datos Guardados Correctamente!");
            return updateCompanyInfo.CompanyID;
        }
        public static CompanyInfo load()
        {
            return SQLiteConn.Query<CompanyInfo>($"SELECT * FROM CompanyInfo").First();
        }
    }
}