
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Controllers
{
    public class WithdrawCashController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            ViewBag.Current = "Withdraw";
            return View();
        }
    }
}
