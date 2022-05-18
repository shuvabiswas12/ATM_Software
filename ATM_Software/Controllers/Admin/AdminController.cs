using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Controllers.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateAccount() { return View(); }

        public IActionResult DeleteAccount() { return View(); }

        public IActionResult UpdateAccount() { return View(); }

        public IActionResult ViewReport() { return View(); }

        public IActionResult UpdateAdminCredentials() { return View(); }
    }
}
