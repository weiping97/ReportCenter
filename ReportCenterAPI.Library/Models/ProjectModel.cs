using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCenterAPI.Library.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CountryId { get; set; }
        public string CountrName { get; set; }
        public bool IsActive { get; set; }
    }
}
