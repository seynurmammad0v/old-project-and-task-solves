using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvTapsiriqiFrontToBack.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _db;
        public SearchController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Search(string val)
        {
            IEnumerable<Product> model = _db.Products.Where(pro=>pro.Name.Contains(val)).OrderByDescending(p=>p.Id).Take(10);
            return PartialView("_SearchPartial", model);
        }
    }
}
