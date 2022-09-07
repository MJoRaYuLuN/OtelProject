using Microsoft.AspNetCore.Mvc;
using OtelProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Areas.yonetim.Controllers
{
    [Area("Yonetim")]
    public class HomeController : Controller
    {
        private readonly MysqlContext c;
        public HomeController(MysqlContext c)
        {
            this.c = c;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
