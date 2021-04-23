using ReportCenterAPI.Library.Models;
using System.Collections.Generic;

namespace ReportCenterAPI.Library.DataAccess
{
    public interface ITelcoData
    {
        List<TelcoModel> GetAllTelco();
        TelcoModel GetById(int Id);
    }
}