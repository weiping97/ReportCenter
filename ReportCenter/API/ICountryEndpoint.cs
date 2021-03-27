using ReportCenter.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReportCenter.API
{
    public interface ICountryEndpoint
    {
        Task<bool> CreateCountryData(CountryModel item);
        Task<List<CountryModel>> GetAllCountry();
    }
}