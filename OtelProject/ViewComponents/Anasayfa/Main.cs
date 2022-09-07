using Microsoft.AspNetCore.Mvc;
using OtelProject.Data.Models;
using OtelProject.ViewModels.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.ViewComponents.Anasayfa
{
    public class Main : ViewComponent
    {
        private readonly MysqlContext c;
        public Main(MysqlContext c)
        {
            this.c = c;
        }
        public IViewComponentResult Invoke()
        {
            MailViewModel mailViewModel = new MailViewModel();
            mailViewModel.odaTips= c.OdaTips.Where(x => x.Act != 0).ToList();
            mailViewModel.Pansiyons = c.Pansiyons.Where(x => x.Act != 0).ToList();
            return View(mailViewModel);
        }
    }
}
