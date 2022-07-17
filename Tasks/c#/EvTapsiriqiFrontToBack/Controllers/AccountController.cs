using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.Helpers;
using EvTapsiriqiFrontToBack.Models;
using EvTapsiriqiFrontToBack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EvTapsiriqiFrontToBack.Areas.FiorelloAdmin.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signManager = signManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
                return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginRegisteVM register)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), register);
            }
            AppUser user = new AppUser()
            {
                FullName = register.RegisterVM.FullName,
                UserName = register.RegisterVM.UserName,
                Email = register.RegisterVM.Email,
                Activeted =false
            };
            IdentityResult identityResult = await _userManager.CreateAsync(user, register.RegisterVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ViewData["RegisterError"] += error.Description;

                }
                return View(nameof(Index), register);

            }
            await _userManager.AddToRoleAsync(user, Helper.Roles.Member.ToString());

            /*await _signManager.SignInAsync(user, true);*/
            TempData["success"] = "Successfuly registreted, wait activation";
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> LoginPost(LoginRegisteVM login)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), login);
            }
            AppUser user  = await _userManager.FindByEmailAsync(login.LoginVM.Email);
            if (user == null)
            {
                ViewData["LoginError"]="Email or Password is Wrong";
                return View("Index", login);
            }
            if(!user.Activeted)
            {
                ViewData["LoginError"]="Please wait Activation";
                return View("Index", login);
            }
            var signInResult = await _signManager.PasswordSignInAsync(user, login.LoginVM.Password, login.LoginVM.RememberMe, true);
            if (!signInResult.Succeeded)
            {
                ViewData["LoginError"]= "Email or Password is Wrong";
                return View("Index", login);
            }

            string role= (await _userManager.GetRolesAsync(user))[0];
            if (role == Helper.Roles.Admin.ToString())
            {
                return RedirectToAction("index", "dashboard",new { area="fiorelloAdmin" });

            }
            else
                return RedirectToAction("index", "home");
        }
        /*      public async Task  CreateRole()
              {   
                  if(! await _roleManager.RoleExistsAsync("Admin"))
                      await _roleManager.CreateAsync(new IdentityRole()
                  {
                      Name = "Admin"
                  });
                  await _roleManager.CreateAsync(new IdentityRole()
                  {
                      Name = "Member"
                  });
              }*/
    }
}
