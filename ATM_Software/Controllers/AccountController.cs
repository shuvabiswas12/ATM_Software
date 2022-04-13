using ATM_Software.Database;
using ATM_Software.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Controllers
{
    public class AccountController : Controller
    {
        private readonly ATMDbContext _db;
        private readonly UserManager<CustomIdentityUser> _usermanager;
        private readonly SignInManager<CustomIdentityUser> _signInManager;

        public AccountController(ATMDbContext db, UserManager<CustomIdentityUser> usermanager, SignInManager<CustomIdentityUser> signInManager)
        {
            this._db = db;
            this._usermanager = usermanager;
            this._signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginData)
        {
            if (ModelState.IsValid)
            {

                var result = await this._signInManager.PasswordSignInAsync(loginData.Email, loginData.Password, loginData.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid login attempt.");
                ViewBag.IsError = "true";
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel registrationData)
        {
            return View();
        }
    }
}
