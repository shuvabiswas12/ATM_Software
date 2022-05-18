using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Controllers
{
    public class CashTransferController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Current = "Transfer";
            return View();
        }
    }
}
