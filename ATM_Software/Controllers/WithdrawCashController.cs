using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Controllers
{
    public class WithdrawCashController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Current = "Withdraw";
            return View();
        }
    }
}
