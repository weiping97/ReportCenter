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

        public async Task<CountryModel> GetCountryById(int Id)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/Country/GetCountryById/{Id}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<CountryModel>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<bool> UpdateCoutryDetail(CountryUpdateModel item)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Country/UpdateCountry", item))
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

        public async Task<bool> DeleteCountryById(int Id)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/Country/DeleteCountryById/{Id}"))
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
