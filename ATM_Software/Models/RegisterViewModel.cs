using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ATM_Software.Utilities.CustomValidations;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Models
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [ValidEmailDomain(allowedDomain:"gmail.com", ErrorMessage = "Email domain should be gmail.com.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "National ID")]
        public string NationalID { get; set; }
    }
}
