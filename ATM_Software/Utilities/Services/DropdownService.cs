using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Utilities.Services
{
    public class DropdownService
    {
        public static IEnumerable<SelectListItem> GetAccountStatus()
        {
            IEnumerable<SelectListItem> accountStatusDropDown = new[]
            {
                new SelectListItem{Value = "Active".ToString(), Text="Active".ToString()},
                new SelectListItem{Value = "Deactive".ToString(), Text="Deactive".ToString()},
            };

            return accountStatusDropDown;
        }

        public static IEnumerable<SelectListItem> GetAccountType()
        {
            IEnumerable<SelectListItem> accountTypeDropDown = new[]
            {
                new SelectListItem{Value = "Savings".ToString(), Text="Savings".ToString()},
                new SelectListItem{Value = "Normal".ToString(), Text="Normal".ToString()},
            };

            return accountTypeDropDown;
        }
    }
}
