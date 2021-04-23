using ReportCenterAPI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public CountryModel GetById(int Id)
        {
            var output = _sql.LoadData<CountryModel, dynamic>("dbo.uspCountry_GetById", new { Id = Id }, "ReportCenterDB").FirstOrDefault();

            return output;
        }

        public void SaveCountryData(CountryModel item)
        {
            var p = new
            {
                Name = item.Name,
                CountryCOde = item.CountryCode
            };

            _sql.SaveData<dynamic>("dbo.uspCountry_SaveData", p, "ReportCenterDB");
        }

        public void UpdateCountryData(CountryUpdateModel item)
        {
            var p = new
            {
                Id = item.Id,
                Name = item.Name,
                IsActive = item.IsActive,
                CountryCode = item.CountryCode,
            };

            _sql.SaveData<dynamic>("dbo.uspCountry_UpdateData", p, "ReportCenterDB");
        }

        public void DeleteCountryData(int Id)
        {
            _sql.SaveData<dynamic>("dbo.uspCountry_DeleteById", new { Id = Id }, "ReportCenterDB");
        }
    }
}
