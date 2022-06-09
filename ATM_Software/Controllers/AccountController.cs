using ATM_Software.Database;
using ATM_Software.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        [Route("Account/Admin")]
        [Route("Account/AdminLogin")]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdminLogin(AdminLoginViewModel adminLoginViewModel)
        {
            return View();
        }

        [HttpGet]
        [Route("Account/Login")]
        [Route("Account/UserLogin")]
        [Route("Account/User")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginData, string returnUrl)
        {


            if (ModelState.IsValid)
            {

                if (loginData.LoginID.ToString().ToLower() == "user1" && loginData.Password.ToString() == "USEr1@1234")
                {
                    var user = new CustomIdentityUser()
                    {
                        UserName = loginData.LoginID,
                        Email = loginData.LoginID,
                        LoginID = loginData.LoginID,
                    };

                    var isUserExist = await _usermanager.FindByEmailAsync(user.Email);

                    IdentityResult result = null;

                    if (isUserExist == null)
                    {
                        result = await this._usermanager.CreateAsync(user, loginData.Password);


                        if (result.Succeeded) { await this.SignInTask(user: loginData, ReturnUrl: returnUrl); }

                    }
                    else
                    {
                        await this.SignInTask(user: loginData, ReturnUrl: returnUrl);
                    }

                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }
            }

            return View();
        }

        private async Task<IActionResult> SignInTask(string ReturnUrl, LoginViewModel user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.LoginID, user.Password, false, false);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(ReturnUrl))
                    return Redirect(ReturnUrl);
                else
                    return RedirectToAction("Index", "Home");
            }

            ViewBag.IsError = "true";
            ModelState.AddModelError(string.Empty, "Invalid Credentials!");

            return RedirectToAction("Index", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
