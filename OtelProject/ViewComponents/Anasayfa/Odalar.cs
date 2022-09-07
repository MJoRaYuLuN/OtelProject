using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtelProject.Data.Models;
using OtelProject.ViewModels.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.ViewComponents.Anasayfa
{
    public class Odalar : ViewComponent
    {
        private readonly MysqlContext c;
        public Odalar(MysqlContext c)
        {
            this.c = c;
        }
        public IViewComponentResult Invoke()
        {
            List<OdalarViewModel> odalarList = new List<OdalarViewModel>();
            var list = c.Odalars.Include(x=>x.OdaTips).Where(x => x.Act != 0).ToList();
            var resimList = c.OdaResims.Where(x => x.Act != 0).ToList();
            var odaOzellikList = c.OdaOzelliks.Where(x => x.Act != 0).ToList();
            foreach (var item in list)
            {
                OdalarViewModel oda = new OdalarViewModel();
                oda.OdaAdi = item.OdaAdi;
                oda.Aciklama = item.Aciklama;
                oda.YatakSayisi = item.YatakSayisi;
                oda.Cephe = item.Cephe;
                oda.Fiyat = item.OdaTips.Ucret.ToString("N2") + "₺";
                oda.OdaResimler = new List<OdaResimViewModel>();
                oda.OdaOzellikler = new List<OdaOzellikViewModel>();
                var resimler = resimList.Where(x => x.OdaId == item.Idno).ToList();
                if (resimler.Count() != 0)
                {
                    foreach (var resims in resimler)
                    {
                        OdaResimViewModel resim = new OdaResimViewModel();
                        resim.Resim = resims.Resim;
                        oda.OdaResimler.Add(resim);
                    }
                }
                if (!String.IsNullOrEmpty(item.Ozellikler))
                {
                    string[] ozellikList = item.Ozellikler.Split(",");
                    for (int i = 0; i < ozellikList.Length; i++)
                    {
                        var odaOzellik = odaOzellikList.FirstOrDefault(x => x.Idno == Convert.ToInt32(ozellikList[i]));
                        OdaOzellikViewModel ozellik = new OdaOzellikViewModel();
                        ozellik.Baslik = odaOzellik.Baslik;
                        ozellik.Ikon = odaOzellik.Ikon;
                        oda.OdaOzellikler.Add(ozellik);
                    }
                }
                odalarList.Add(oda);
            }
            return View(odalarList);
        }
    }
}
