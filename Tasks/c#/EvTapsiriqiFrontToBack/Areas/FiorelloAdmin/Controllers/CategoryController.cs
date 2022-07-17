using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Helpers;
using EvTapsiriqiFrontToBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvTapsiriqiFrontToBack.Areas.FiorelloAdmin.Controllers
{
    [Area("FiorelloAdmin")]
    [Authorize(Roles ="Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> model = _db.Categories;
            return View(model);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Category ctg = await _db.Categories.FindAsync(id);
            if (ctg == null) return NotFound();
            return View(ctg);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Create(Category ctg)
        {
            if (!ModelState.IsValid) return View(ctg);
            bool isExist = _db.Categories.Any(c => c.Name.ToLower() == ctg.Name.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Category artiq movcuddur!");
                return View(ctg);
            }
            await _db.Categories.AddAsync(ctg);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Category ctg = await _db.Categories.FindAsync(id);
            if (ctg == null) return NotFound();
            return View(ctg);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> Update(int? id,Category ctg)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return View(ctg);
            Category dbCtg =await _db.Categories.FindAsync(id);
            if (dbCtg == null) return NotFound();
            if (dbCtg.Name.ToLower() != ctg.Name.ToLower())

            {
                bool isExist = _db.Categories.Any(c => c.Name.ToLower() == ctg.Name.ToLower());
                if (isExist)
                {
                    ModelState.AddModelError("Name", "Bu Category artiq movcuddur!");
                    return View(ctg);
                }
               
            }
            dbCtg.Name = ctg.Name;
            dbCtg.Description = ctg.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Category ctg = await _db.Categories.FindAsync(id);
            if (ctg == null) return NotFound();
            _db.Categories.Remove(ctg);
            await _db.SaveChangesAsync();
            return Json("Deleted");
        }
        }
}
