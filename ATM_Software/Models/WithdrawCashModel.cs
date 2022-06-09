using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Models
{
    public class WithdrawCashModel
    {
        [Required]
        [Display(Name = "Withdraw Mode")]
        public string WithdrawMode { get; set; }

        [Required]
        public double Amount { get; set; }

        [Display(Name = "Withdraw At")]
        public DateTime WithdrawAt { get; set; }
    }
}
