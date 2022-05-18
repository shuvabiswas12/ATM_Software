using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Controllers
{
    public class DisplayBalanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
