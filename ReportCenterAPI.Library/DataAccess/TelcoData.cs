using ReportCenterAPI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportCenterAPI.Library.DataAccess
{
    public class TelcoData : ITelcoData
    {
        private ISqlDataAccess _sql;

        public TelcoData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<TelcoModel> GetAllTelco()
        {
            var output = _sql.LoadData<TelcoModel, dynamic>("uspTelco_GetAll", new { }, "ReportCenterDB");
            return output;
        }

        public TelcoModel GetById(int Id)
        {
            var output = _sql.LoadData<TelcoModel, dynamic>("uspTelco_GetById", new { Id = Id }, "ReportCenterDB").FirstOrDefault();
            return output;
        }

    }
}
