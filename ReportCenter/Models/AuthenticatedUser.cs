using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportCenter.Models
{
    public class AuthenticatedUser
    {
        public string AccessToken { get; set; }
        public string UserName { get; set; }
    }
}
