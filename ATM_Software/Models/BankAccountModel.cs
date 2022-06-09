using ATM_Software.Utilities.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Models
{
    public class BankAccountModel
    {
        public int Id { get; set; }

        [Display(Name = "Login ID")]
        public string LoginID { get; set; }


        [Display(Name = "Pin Code")]
        public string PinCode { get; set; }

        [Required]
        [Display(Name = "Country Identity / NID")]
        [MinLength(5, ErrorMessage = "Country Identity or NID length should not less than 5 digits.")]
        public string Nid { get; set; }

        [Required]
        [Display(Name = "Holder's Name")]
        [MinLength(3, ErrorMessage = "Holders name's length should not smaller than 3 digits.")]
        [MaxLength(20, ErrorMessage = "Holders name's length should not larger than 20 digits.")]
        public string HolderName { get; set; }

        [Required]
        [EmailAddress]
        [ValidEmailDomain(allowedDomain: "gmail.com", ErrorMessage = "Domain should be gmail.com.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Starting Balance")]
        [ValidStartingBalance(startingBalance: 499, ErrorMessage = "Minimum starting balance should be 500 Taka.")]
        public double Balance { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public string AccountType { get; set; }

        [Required]
        [Display(Name = "Account Status")]
        public string AccountIsActive { get; set; }

        [Display(Name = "Account Number")]
        public long AccountNumber { get; set; }
    }
}
