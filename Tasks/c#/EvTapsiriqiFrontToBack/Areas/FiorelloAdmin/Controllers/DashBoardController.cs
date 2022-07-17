using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvTapsiriqiFrontToBack.Areas.FiorelloAdmin.Controllers
{
    [Area("FiorelloAdmin")]
    [Authorize(Roles = "Admin")]


    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
