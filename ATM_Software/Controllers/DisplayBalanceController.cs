using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Controllers
{
    public class DisplayBalanceController : Controller
    {
        [Authorize(policy: "UserRoles")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
