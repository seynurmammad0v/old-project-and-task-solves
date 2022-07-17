using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Models;
using EvTapsiriqiFrontToBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EvTapsiriqiFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM hoveVM = new HomeVM
            {
                Sliders = _db.Sliders,
                SliderDescription = _db.SliderDescriptions.FirstOrDefault(),
                Categories = _db.Categories,
                Products = _db.Products.Include(p => p.Category).Take(8),
                ValentineDescriptions = _db.ValentineDescriptions.FirstOrDefault(),
                FlowerExperts = _db.FlowerExperts.FirstOrDefault(),
                FlowerExpertItems= _db.FlowerExpertItems,
                EmailSections = _db.EmailSections.FirstOrDefault(),
                Blogs = _db.Blogs.FirstOrDefault(),
                BlogItems = _db.BlogItems,
                SliderFlorists = _db.SliderFlorists
            };
            return View(hoveVM);
        }
       
      
    }
}
