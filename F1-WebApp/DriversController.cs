using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace F1_WebApp
{
    public class DriversController : Controller
    {
        public IActionResult Index()
        {
            DriversDataContext context = HttpContext.RequestServices.GetService(typeof(F1_WebApp.Models.DriversDataContext)) as DriversDataContext;

            return View(context.GetAllDrivers());
        }
    }
}