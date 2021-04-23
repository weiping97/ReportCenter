using ReportCenter.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReportCenter.API
{
    public interface ITelcoEndpoint
    {
        Task<bool> CreateTelco(TelcoModel item);
        Task<List<TelcoModel>> GetAllTelco();
        Task<TelcoModel> GetTelcoById(int Id);
        Task<bool> UpdateTelco(string name);
    }
}