using ReportCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReportCenter.API
{
    public class CountryEndpoint : ICountryEndpoint
    {
        private IAPIHelper _apiHelper;
        public CountryEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<CountryModel>> GetAllCountry()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Country/GetAllCountry"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<CountryModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<bool> CreateCountryData(CountryModel item)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Country/CreateCountry", item))
            {
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
