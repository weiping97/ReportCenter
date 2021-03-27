using ReportCenterAPI.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCenterAPI.Library.DataAccess
{
    public class ProjectData
    {
        private readonly ISqlDataAccess _sql;
        public ProjectData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<ProjectModel> GetAllProjects()
        {
            var output = _sql.LoadData<ProjectModel, dynamic>("dbo.uspProject_GetAll", new { }, "ReportCenterDB");

            return output;
        }
    }
}
