using EvTapsiriqiFrontToBack.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Areas.FiorelloAdmin.ViewComponents
{
    [Area("FiorelloAdmin")]

    public class HeaderAdminViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public HeaderAdminViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.MainSliderCount = _db.Sliders.Count();
            return View();
        }
    }
}
