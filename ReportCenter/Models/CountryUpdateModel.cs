using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportCenter.Models
{
    public class CountryUpdateModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage ="You need to enter at least 3 characters")]
        public string Name { get; set; }
        [MinLength(2, ErrorMessage = "You need to enter at least 2 characters")]
        [Required]
        public string CountryCode { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
