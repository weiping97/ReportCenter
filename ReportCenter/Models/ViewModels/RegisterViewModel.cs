using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportCenter.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Required]
        public string ConfirmPassword { get; set; }
        [DisplayName("First Name")]
        [MaxLength(50, ErrorMessage = "You need to keep the name to a max of 50 characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [MaxLength(50, ErrorMessage = "You need to keep the name to a max of 50 characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters")]
        [Required]
        public string LastName { get; set; }
    }
}
