using ReportCenterAPI.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCenterAPI.Library.DataAccess
{
    public class CountryData : ICountryData
    {
        private readonly ISqlDataAccess _sql;
        public CountryData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<CountryModel> GetAllCountry()
        {
            var output = _sql.LoadData<CountryModel, dynamic>("dbo.uspCountry_GetAll", new { }, "ReportCenterDB");

            return output;
        }

        public void SaveCountryData(CountryModel item)
        {
            _sql.SaveData<dynamic>("dbo.uspCountry_SaveData", item, "ReportCenterDB");
        }
    }
}
