using ReportCenterAPI.Library.Models;
using System.Collections.Generic;

namespace ReportCenterAPI.Library.DataAccess
{
    public interface ICountryData
    {
        List<CountryModel> GetAllCountry();
        void SaveCountryData(CountryModel item);
    }
}