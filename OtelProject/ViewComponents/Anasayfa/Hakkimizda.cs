using Microsoft.AspNetCore.Mvc;
using OtelProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.ViewComponents.Anasayfa
{
    public class Hakkimizda : ViewComponent
    {
        private readonly MysqlContext c;
        public Hakkimizda(MysqlContext c)
        {
            this.c = c;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
