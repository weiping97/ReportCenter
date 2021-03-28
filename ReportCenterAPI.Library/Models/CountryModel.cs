using System;
using System.Collections.Generic;
using System.Text;

namespace ReportCenterAPI.Library.Models
{
    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string CountryCode { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
