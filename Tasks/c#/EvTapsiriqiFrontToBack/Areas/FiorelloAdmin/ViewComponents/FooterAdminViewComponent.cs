using EvTapsiriqiFrontToBack.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Areas.FiorelloAdmin.ViewComponents
{
    [Area("FiorelloAdmin")]


    public class FooterAdminViewComponent : ViewComponent
    {
     
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
