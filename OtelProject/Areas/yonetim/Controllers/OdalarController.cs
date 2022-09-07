using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OtelProject.Data.Models;
using OtelProject.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Areas.yonetim.Controllers
{
    [Area("Yonetim")]
    public class OdalarController : Controller
    {
        private readonly MysqlContext c;
        public OdalarController(MysqlContext c)
        {
            this.c = c;
        }
        public IActionResult Index()
        {
            var list = c.Odalars.Include(x => x.OdaTips).Where(x => x.Act != 0).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult YeniOda(int id)
        {
            Odalar odalar = new Odalar();
            List<SelectListItem> odatips = (from p in c.OdaTips.ToList().Where(p => p.Act == 1).OrderBy(p => p.Baslik)
                                            select new SelectListItem
                                            {
                                                Text = p.Baslik,
                                                Value = p.Idno.ToString()
                                            }).ToList();
            ViewBag.odaTip = odatips;
            if (id != 0)
            {
                odalar = c.Odalars.SingleOrDefault(x => x.Idno == id);
            }
            return View(odalar);
        }
        [HttpPost]
        public IActionResult YeniOda(Odalar oda)
        {
            if (oda.Idno == 0)
            {
                oda.Act = 1;
                c.Set<Odalar>().Add(oda);
                c.SaveChanges();
                TempData["success"] = "Yeni oda başarıyla eklendi.";
            }
            else
            {
                var x = c.Odalars.SingleOrDefault(x => x.Idno == oda.Idno);
                x.OdaAdi = oda.OdaAdi;
                x.OdaNo = oda.OdaNo;
                x.OdaTip = oda.OdaTip;
                x.YatakSayisi = oda.YatakSayisi;
                x.Cephe = oda.Cephe;
                c.Set<Odalar>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Oda başarıyla güncellendi.";
            }
            return RedirectToAction("Index", "Odalar");
        }
        public IActionResult OdaSil(int id)
        {
            if (id != 0)
            {
                var x = c.Odalars.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<Odalar>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Odadan başarıyla silindi";
                }
                else
                    TempData["error"] = "Oda bulunamadı";
            }
            else
                TempData["error"] = "Oda bulunamadı";
            return RedirectToAction("Index", "Odalar");
        }
        public IActionResult OdaTip()
        {
            var list = c.OdaTips.Where(x => x.Act != 0).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult YeniTip(int id)
        {
            OdaTip tip = new OdaTip();
            if (id != 0)
                tip = c.OdaTips.SingleOrDefault(x => x.Idno == id && x.Act == 1);

            if (tip != null)
                return View(tip);
            else
                return RedirectToAction("Index", "Odalar");
        }

        [HttpPost]
        public IActionResult YeniTip(OdaTip tip)
        {
            if (tip.Idno == 0)
            {
                tip.Act = 1;
                c.Set<OdaTip>().Add(tip);
                c.SaveChanges();
                TempData["success"] = "Oda tipi eklendi";
            }
            else
            {
                var x = c.OdaTips.SingleOrDefault(x => x.Idno == tip.Idno);
                x.Baslik = tip.Baslik;
                x.Ucret = tip.Ucret;
                c.Set<OdaTip>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Oda tipi güncellendi";
            }
            return RedirectToAction("OdaTip", "Odalar");
        }

        public IActionResult TipSil(int id)
        {
            if (id != 0)
            {
                var x = c.OdaTips.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<OdaTip>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Oda tipi silindi";
                }
                else
                    TempData["error"] = "Oda tipi bulunamadı";
            }
            else
                TempData["error"] = "Oda Tipi Bulunamadı";
            return RedirectToAction("OdaTip", "Odalar");
        }
        public IActionResult Pansiyonlar()
        {
            var list = c.Pansiyons.Where(x => x.Act != 0).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult YeniPansiyon(int id)
        {
            Pansiyon pansiyon = new Pansiyon();
            if (id != 0)
                pansiyon = c.Pansiyons.SingleOrDefault(x => x.Idno == id && x.Act == 1);

            if (pansiyon != null)
                return View(pansiyon);
            else
                return RedirectToAction("Pansiyonlar", "Odalar");
        }
        [HttpPost]
        public IActionResult YeniPansiyon(Pansiyon pansiyon)
        {

            if (pansiyon.Idno == 0)
            {
                pansiyon.Act = 1;
                c.Set<Pansiyon>().Add(pansiyon);
                c.SaveChanges();
                TempData["success"] = "Pansiyon eklendi";
            }
            else
            {
                var x = c.Pansiyons.SingleOrDefault(x => x.Idno == pansiyon.Idno);
                x.Baslik = pansiyon.Baslik;
                x.Ucret = pansiyon.Ucret;
                c.Set<Pansiyon>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Pansiyon güncellendi";
            }
            return RedirectToAction("Pansiyonlar", "Odalar");
        }
        public IActionResult PansiyonSil(int id)
        {
            if (id != 0)
            {
                var x = c.Pansiyons.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<Pansiyon>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Pansiyon silindi";
                }
                else
                    TempData["error"] = "Pansiyon bulunamadı";
            }
            else
                TempData["error"] = "Pansiyon bulunamadı";
            return RedirectToAction("Pansiyon", "Odalar");
        }
        public IActionResult OdaOzellik()
        {
            var list = c.OdaOzelliks.Where(x => x.Act != 0).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult YeniOzellik(int id)
        {
            OdaOzellik ozellik = new OdaOzellik();
            if (id != 0)
                ozellik = c.OdaOzelliks.SingleOrDefault(x => x.Idno == id && x.Act == 1);

            if (ozellik != null)
                return View(ozellik);
            else
                return RedirectToAction("OdaOzellik", "Odalar");
        }
        [HttpPost]
        public IActionResult YeniOzellik(OdaOzellik ozellik)
        {
            if (ozellik.Idno == 0)
            {
                ozellik.Act = 1;
                c.Set<OdaOzellik>().Add(ozellik);
                c.SaveChanges();
                TempData["success"] = "Oda özelliği eklendi";
            }
            else
            {
                var x = c.OdaOzelliks.SingleOrDefault(x => x.Idno == ozellik.Idno);
                x.Baslik = ozellik.Baslik;
                x.Ikon = ozellik.Ikon;
                c.Set<OdaOzellik>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Oda özelliği güncellendi";
            }
            return RedirectToAction("OdaOzellik", "Odalar");
        }
        public IActionResult OzellikEkle(int id)
        {
            List<OzellikSecimViewModel> secimList = new List<OzellikSecimViewModel>();
            var list = c.OdaOzelliks.Where(x => x.Act != 0).ToList();
            foreach (var item in list)
            {
                OzellikSecimViewModel secim = new OzellikSecimViewModel();
                secim.Baslik = item.Baslik;
                secim.OzellikId = item.Idno;
                secim.Secim = false;
                var odaOzellik = c.Odalars.SingleOrDefault(x => x.Act != 0 && x.Idno == id);
                if (!String.IsNullOrEmpty(odaOzellik.Ozellikler))
                {
                    string[] ozellikler = odaOzellik.Ozellikler.Split(",");
                    for (int i = 0; i < ozellikler.Length; i++)
                    {
                        if (ozellikler[i] == item.Idno.ToString())
                            secim.Secim = true;
                    }
                }
                secimList.Add(secim);
            }
            ViewBag.Id = id;
            return View(secimList);
        }
        [HttpPost]
        public IActionResult OzellikEkle(string[] ozellik, int odaid) //EKSİK
        {
            string odaozellik = "";
            for (int i = 0; i < ozellik.Length; i++)
            {
                odaozellik += ozellik[i] + ",";
            }
            odaozellik = odaozellik.Substring(0, odaozellik.Length - 1);
            var x = c.Odalars.FirstOrDefault(x => x.Idno == odaid);
            x.Ozellikler = odaozellik;
            c.Set<Odalar>().Update(x);
            c.SaveChanges();
            return RedirectToAction("Index", "Odalar");
        }
        public IActionResult OzellikSil(int id)
        {
            if (id != 0)
            {
                var x = c.OdaOzelliks.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<OdaOzellik>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Oda özelliği silindi";
                }
                else
                    TempData["error"] = "Özellik bulunamadı";
            }
            else
                TempData["error"] = "Özellik bulunamadı";
            return View();
        }
        public IActionResult OdaResimler(int id)
        {
            ViewBag.Odaid = id;
            var list = c.OdaResims.Where(x => x.Act != 0 && x.OdaId == id).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult ResimEkle(int id)
        {
            OdaResimViewModel resim = new OdaResimViewModel();
            resim.OdaId = id;
            ViewBag.OdaId = id;
            return View(resim);
        }
        [HttpPost]
        public IActionResult ResimEkle(OdaResimViewModel resim, int OdaId)
        {
            OdaResim odaResim = new OdaResim();
            if (resim.Resim != null)
            {
                var extension = Path.GetExtension(resim.Resim.FileName);
                var resimadi = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/", resimadi);
                var stream = new FileStream(location, FileMode.Create);
                resim.Resim.CopyTo(stream);
                odaResim.Resim = resimadi;
            }
            odaResim.OdaId = OdaId;
            odaResim.Act = 1;
            c.Set<OdaResim>().Add(odaResim);
            c.SaveChanges();
            TempData["success"] = "Oda resmi başarıyla eklendi";
            return RedirectToAction("Index", "Odalar");
        }
        public IActionResult ResimSil(int id)
        {
            if (id != 0)
            {
                var x = c.OdaResims.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<OdaResim>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Oda resmi silindi";
                }
                else
                    TempData["error"] = "Oda resmi bulunamadı";
            }
            else
                TempData["error"] = "Oda resmi bulunamadı";
            return View();
        }
    }
}
