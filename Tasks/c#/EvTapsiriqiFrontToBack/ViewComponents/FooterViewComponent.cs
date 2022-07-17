using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = _db.Bio.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
