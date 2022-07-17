using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Models;
using EvTapsiriqiFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvTapsiriqiFrontToBack.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.ProductCount = _db.Products.Count();
            HomeVM Products =new HomeVM() { 
            Products = _db.Products.Include(p => p.Category).Take(8)
            };
            return View(Products);
        }
        public IActionResult LoadMore(int skip)
        {
            HomeVM Model = new HomeVM()
            {
                Products = _db.Products.Include(p => p.Category).Skip(skip).Take(8)
            };
            return PartialView("_ProductPartial",Model);
        }
    }
}
