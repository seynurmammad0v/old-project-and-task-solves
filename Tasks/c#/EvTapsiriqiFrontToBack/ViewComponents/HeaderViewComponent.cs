using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Models;
using EvTapsiriqiFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public HeaderViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.BasketCount= 0;
            ViewBag.TotalPrice= 0;
            if (Request.Cookies["basket"] != null)
            {
                List <BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
                ViewBag.BasketCount = basket.Count();
                double total = 0;
                foreach (BasketVM p in basket)
                {
                    total += _db.Products.Find(p.Id).Price * p.Count;
                }
                ViewBag.TotalPrice = "$"+total;
            }
            Bio bio = _db.Bio.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
