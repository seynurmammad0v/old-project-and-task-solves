using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Models;
using EvTapsiriqiFrontToBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EvTapsiriqiFrontToBack.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _db;
        public BasketController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            List<BasketRazorVM> basketsRazor = new List<BasketRazorVM>();
            foreach (BasketVM item in basket)
            {
                Product product =await _db.Products.FindAsync(item.Id);
                BasketRazorVM basketRazorVM = new BasketRazorVM()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Image = product.Image,
                    Count = item.Count
                };
                basketsRazor.Add(basketRazorVM);

            }
            return View(basketsRazor);
        }
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            Product product = await _db.Products.FindAsync(id);
            if (product == null) return NotFound();
            List<BasketVM> listBasketVM = new List<BasketVM>();
            if (Request.Cookies["basket"] != null)
            {
                listBasketVM = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            BasketVM isExistProduct = listBasketVM.FirstOrDefault(b => b.Id == id);
            if (isExistProduct == null)
            {
                BasketVM basketVM = new BasketVM()
                {
                    Id = product.Id,
                    Count = 1
                };
                listBasketVM.Add(basketVM);

            }
            else
            {
                isExistProduct.Count++;
            }
            string basket = JsonConvert.SerializeObject(listBasketVM);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(10) });
            return RedirectToAction("Index", "Home");

        }
        public  IActionResult DeleteBasketProduct(int id)
        {
            List<BasketVM> listBasketVM  = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            listBasketVM.Remove(listBasketVM.Find(p => p.Id == id));
            string basket = JsonConvert.SerializeObject(listBasketVM);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(10) });
            return Redirect("Index");
        }

    }
}
