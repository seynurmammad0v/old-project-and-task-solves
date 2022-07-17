using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Helpers;
using EvTapsiriqiFrontToBack.Models;
using EvTapsiriqiFrontToBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EvTapsiriqiFrontToBack.Controllers
{
    [Area("fiorelloAdmin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<AppUser> userManager, AppDbContext db, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _db = db;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> appUsers = _userManager.Users.ToList();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (AppUser user in appUsers)
            {
                UserVM userVM = new UserVM()
                {
                    Id = user.Id,
                    FullName = user.FullName,
                    Email = user.Email,
                    UserName = user.UserName,
                    Activeted = user.Activeted,
                    Role = ((await _userManager.GetRolesAsync(user))[0])

                };
                userVMs.Add(userVM);
            }
            return View(userVMs);
        }
        public async Task<IActionResult> AccountStatus(string id)
        {
            if (id == null) return NotFound();

            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            if (User.Identity.Name == user.UserName) return NotFound();
            if (user.Activeted)
            {
                user.Activeted = false;
            }
            else
                user.Activeted = true;
            await _db.SaveChangesAsync();
            return Json("changed!");

        }
        public async Task<IActionResult> ChangeRole(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            if (User.Identity.Name == user.UserName) return NotFound();
            UserVM userVM = new UserVM()
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                UserName = user.UserName,
                Activeted = user.Activeted,
                Role = ((await _userManager.GetRolesAsync(user))[0]),
                Roles= new List<string> { Helper.Roles.Admin.ToString(), Helper.Roles.Member.ToString() }

            };
            return View(userVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id,string role)
        {
            if (role == null) return NotFound();
            if (id == null) return NotFound();
            if (await _roleManager.RoleExistsAsync(role)) return NotFound();
             AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            if (User.Identity.Name == user.UserName) return NotFound();

            string oldRole =(await _userManager.GetRolesAsync(user))[0];
            IdentityResult identityResult= await _userManager.RemoveFromRoleAsync(user, oldRole);
            if (!identityResult.Succeeded)
            {
                TempData["error"] = "Cant change role";
                return RedirectToAction("index");
            }
            
            IdentityResult identityResultNew = await _userManager.AddToRoleAsync(user, role);
            if (!identityResultNew.Succeeded)
            {
                TempData["error"] = "Cant change role";
                return RedirectToAction("index");
            }
            return RedirectToAction("index");
        }
        public async Task<IActionResult> ResetPassword(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            UserVM userVM = new UserVM()
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                UserName = user.UserName,
                Activeted = user.Activeted,
                Role = ((await _userManager.GetRolesAsync(user))[0]),
                Roles = new List<string> { Helper.Roles.Admin.ToString(), Helper.Roles.Member.ToString() }

            };
            return View(userVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(string id, string NewPassword)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
         IdentityResult identityResult =  await _userManager.ResetPasswordAsync(user,token,NewPassword);
            if (!identityResult.Succeeded)
            {
                TempData["error"] = "";
                foreach (var item in identityResult.Errors)
                {
                    TempData["error"] += item.Description.ToString();
                }
                return View(user);
            }
            return RedirectToAction("index");
        }
    }
}
