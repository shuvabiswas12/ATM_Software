using ATM_Software.Utilities.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Models
{
    public class BankAccountViewModel
    {
        public BankAccountModel BankAccountModel { get; set; }

        public IEnumerable<SelectListItem> AccountTypeDropdown
        {
            get
            {
                return DropdownService.GetAccountType();
            }
        }

        public IEnumerable<SelectListItem> AccountStatusDropdown { 
            get {
                return DropdownService.GetAccountStatus();
            } 
        }

    }
}
