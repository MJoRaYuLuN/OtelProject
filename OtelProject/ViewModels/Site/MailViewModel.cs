using OtelProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.ViewModels.Site
{
    public class MailViewModel
    {
        public List<OdaTip> odaTips { get; set; }
        public List<Pansiyon> Pansiyons { get; set; }
    }
}
