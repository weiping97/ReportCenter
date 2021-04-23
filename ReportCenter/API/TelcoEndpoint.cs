using ReportCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReportCenter.API
{
    public class TelcoEndpoint : ITelcoEndpoint
    {
        private IAPIHelper _apiHelper;
        public TelcoEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<TelcoModel>> GetAllTelco()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Telco/GetAllTelco"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<TelcoModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<TelcoModel> GetTelcoById(int Id)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Telco/GetById"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<TelcoModel>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<bool> CreateTelco(TelcoModel item)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Telco/CreateTelco", item))
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

        public async Task<bool> UpdateTelco(string name)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Telco/UpdateTelco", new { Name = name }))
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
