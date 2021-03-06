using ReportCenter.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReportCenter.API
{
    public interface ICountryEndpoint
    {
        Task<bool> CreateCountryData(CountryModel item);
        Task<bool> DeleteCountryById(int Id);
        Task<List<CountryModel>> GetAllCountry();
        Task<CountryModel> GetCountryById(int Id);
        Task<bool> UpdateCoutryDetail(CountryUpdateModel item);
    }
}