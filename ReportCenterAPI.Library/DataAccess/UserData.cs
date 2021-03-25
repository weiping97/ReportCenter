using Microsoft.Extensions.Configuration;
using ReportCenterAPI.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCenterAPI.Library.DataAccess
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _sql;

        public UserData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<UserModel> GetUserById(string Id)
        {
            var p = new { Id = Id };

            var output = _sql.LoadData<UserModel, dynamic>("dbo.uspUserLookup", p, "ReportCenterDB");

            return output;
        }
    }
}
