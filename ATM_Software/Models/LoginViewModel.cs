using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login ID")]
        public string LoginID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Pin code")]
        public string Password { get; set; }
    }
}
