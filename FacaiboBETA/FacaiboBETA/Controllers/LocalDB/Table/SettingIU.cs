using System;
using System.Linq;
using FacaiboBETA.Controllers.LocalConn;
using FacaiboBETA.Models;
using SQLite;

namespace FacaiboBETA.Controllers.LocalDB.Table
{
    public class SettingIU : Setting
    {
        static SQLiteConnection SQLiteConn = cmdConn.getConn();
        public string ClientDir { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public bool? _boRemenberAcount { get; set; }
        public bool? _boManageInventary { get; set; }
        public bool? _boManageProductCode { get; set; }
        public bool? _boControlBankingEntity { get; set; }
        public bool? _boControlRNC { get; set; }
        public bool? _boControlPayMethod { get; set; }
        public bool? _boControlClientData { get; set; }
        public bool? _boControlTaxes { get; set; }
        public SettingIU()
        {
        }
        public string save()
        {
            var findUser = SQLiteConn.Query<Setting>($"SELECT * FROM Setting");
            if (!findUser.Any())
                return insert();

            return update(findUser.First());
        }
        public string insert()
        {
            Setting insertSetting = new Setting();
            insertSetting = defaultSetting();
            insertSetting.strSettingID = Guid.NewGuid().ToString();
            insertSetting.strUsername = this.strUsername.Trim().ToUpper();

            if (checkData.str(this.strUsername))
                insertSetting.strUsername = this.strUsername;

            if (checkData.bo(this._boRemenberAcount))
                insertSetting.boRemenberAcount = Convert.ToBoolean(this._boRemenberAcount);

            if (checkData.bo(this._boManageInventary))
                insertSetting.boManageInventary = Convert.ToBoolean(this._boManageInventary);

            if (checkData.bo(this._boManageProductCode))
                insertSetting.boManageProductCode = Convert.ToBoolean(this._boManageProductCode);

            if (checkData.bo(this._boControlBankingEntity))
                insertSetting.boControlBankingEntity = Convert.ToBoolean(this._boControlBankingEntity);

            if (checkData.bo(this._boControlRNC))
                insertSetting.boControlRNC = Convert.ToBoolean(this._boControlRNC);

            if (checkData.bo(this._boControlPayMethod))
                insertSetting.boControlPayMethod = Convert.ToBoolean(this._boControlPayMethod);

            if (checkData.bo(this._boControlClientData))
                insertSetting.boControlClientData = Convert.ToBoolean(this._boControlClientData);

            if (checkData.bo(this._boControlTaxes))
                insertSetting.boControlTaxes = Convert.ToBoolean(this._boControlTaxes);

            SQLiteConn.Insert(insertSetting);

            return insertSetting.strSettingID;
        }
        public string update(Setting inSetting)
        {
            Setting updateSetting = new Setting();
            updateSetting.strSettingID = inSetting.strSettingID;

            if (checkData.str(this.strUsername))
                updateSetting.strUsername = this.strUsername;

            if (checkData.bo(this._boRemenberAcount))
                updateSetting.boRemenberAcount = Convert.ToBoolean(this._boRemenberAcount);

            if (checkData.bo(this._boManageInventary))
                updateSetting.boManageInventary = Convert.ToBoolean(this._boManageInventary);

            if (checkData.bo(this._boManageProductCode))
                updateSetting.boManageProductCode = Convert.ToBoolean(this._boManageProductCode);

            if (checkData.bo(this._boControlBankingEntity))
                updateSetting.boControlBankingEntity = Convert.ToBoolean(this._boControlBankingEntity);

            if (checkData.bo(this._boControlRNC))
                updateSetting.boControlRNC = Convert.ToBoolean(this._boControlRNC);

            if (checkData.bo(this._boControlPayMethod))
                updateSetting.boControlPayMethod = Convert.ToBoolean(this._boControlPayMethod);

            if (checkData.bo(this._boControlClientData))
                updateSetting.boControlClientData = Convert.ToBoolean(this._boControlClientData);

            if (checkData.bo(this._boControlTaxes))
                updateSetting.boControlTaxes = Convert.ToBoolean(this._boControlTaxes);

            SQLiteConn.Update(updateSetting);

            return updateSetting.strSettingID;
        }

        public Setting defaultSetting()
        {
            Setting defSetting = new Setting() { 
                boRemenberAcount = false,
                boManageInventary = true,
                boManageProductCode = true,
                boControlBankingEntity = true,
                boControlRNC = true,
                boControlPayMethod = true,
                boControlClientData = true,
                boControlTaxes = true
            };

            return defSetting;
        }
    }
}