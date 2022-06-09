using ATM_Software.Models;
using ATM_Software.Utilities.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Controllers.Admin
{     
    public class AdminController : Controller
    {
        [Route("Admin/")]
        [Route("[controller]/[action]")]
        [Authorize]
        [HttpGet]
        public IActionResult CreateAccount()
        {
            BankAccountViewModel bankAccountViewModel = new BankAccountViewModel()
            {
                BankAccountModel = new BankAccountModel(),
            };
            
            return View(bankAccountViewModel);
        }

        [Route("Admin/")]
        [Route("[controller]/[action]")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(policy: "AdminRoles")]
        public IActionResult CreateAccount(BankAccountViewModel bankAccountViewModel)
        {
            if (ModelState.IsValid)
            {
                bankAccountViewModel.BankAccountModel.AccountNumber = CreateAccountService.GenerateAccountNumber();
                bankAccountViewModel.BankAccountModel.LoginID = CreateAccountService.GenerateLoginId();
                bankAccountViewModel.BankAccountModel.PinCode = CreateAccountService.GeneratePincode();

                if (CreateAccountService.CreateAccount(bankAccountViewModel.BankAccountModel))
                {
                    // creation success
                }
                else
                {
                    // creation failed.
                }
            }
            return View(bankAccountViewModel);
        }

        [Authorize(policy: "AdminRoles")]
        public IActionResult UpdateAccount()
        {
            return View();
        }

        [Authorize(policy: "AdminRoles")]
        public IActionResult DeleteAccount()
        {
            return View();
        }
    }
}
