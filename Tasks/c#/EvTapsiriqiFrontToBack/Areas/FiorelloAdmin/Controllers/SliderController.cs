using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Extentions;
using EvTapsiriqiFrontToBack.Helpers;
using EvTapsiriqiFrontToBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Areas.FiorelloAdmin.Controllers
{
    [Area("FiorelloAdmin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Sliders);
        }
        public IActionResult Create()
        {
            if (_db.Sliders.Count() >= 5) return RedirectToAction(nameof(Index));
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Sliders slider)
        {
            if (ModelState["Photos"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }
            if (_db.Sliders.Count() + slider.Photos.Length > 5)
            {
                ModelState.AddModelError("Photos", "You can show only 5 slides");
                return View();
            }
            List<Sliders> sliders = new List<Sliders>();
            foreach (var item in slider.Photos)
            {
                if (!item.IsType("image/"))
                {
                    ModelState.AddModelError("Photos", $" {item.FileName} fayli sekil deyil,sekil secin!");
                    return View();

                }
                if (item.MaxLenght(300))
                {
                    ModelState.AddModelError("Photos", $"Image-{item.FileName} size should be less than 300 kb!");
                    return View();
                }
                string fileName = await item.SaveImage(_env.WebRootPath, "img", "slider images");
                Sliders newSlide = new Sliders();
                newSlide.Image = fileName;
                sliders.Add(newSlide);

            }
            await _db.Sliders.AddRangeAsync(sliders);

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Sliders slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Sliders slider)
        {
            if(slider.Photo != null)
            {
                if (!slider.Photo.IsType("image/"))
                {
                    ModelState.AddModelError("Photo", "Sekil secin!");
                    return View();

                }
                if (slider.Photo.MaxLenght(300))
                {
                    ModelState.AddModelError("Photo", "Image size should be less than 300 kb!");
                    return View();
                }
                string fileName = await slider.Photo.SaveImage(_env.WebRootPath, "img", "slider images");
                Sliders sliderDb = await _db.Sliders.FindAsync(id);
                Helper.DeleteFile(_env.WebRootPath, sliderDb.Image,"img","slider images");
                sliderDb.Image = fileName;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Sliders slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            Helper.DeleteFile(_env.WebRootPath, slider.Image, "img", "slider images");
            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync();
            return Json("Deleted");
        }

    }
}
