using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportCenter.Models
{
    public class CountryModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string CountryCode { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
