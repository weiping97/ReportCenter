using ReportCenterAPI.Library.Models;
using System.Collections.Generic;

namespace ReportCenterAPI.Library.DataAccess
{
    public interface ICountryData
    {
        void DeleteCountryData(int Id);
        List<CountryModel> GetAllCountry();
        CountryModel GetById(int Id);
        void SaveCountryData(CountryModel item);
        void UpdateCountryData(CountryUpdateModel item);
    }
}