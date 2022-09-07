using Microsoft.AspNetCore.Mvc;
using OtelProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Areas.yonetim.Controllers
{
    [Area("Yonetim")]
    public class MusteriController : Controller
    {
        private readonly MysqlContext c;
        public MusteriController(MysqlContext c)
        {
            this.c = c;
        }
        public IActionResult Index()
        {
            var list = c.Musteris.Where(x => x.Act != 0).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult YeniMusteri(int id)
        {
            Musteri musteri = new Musteri();
            musteri.DogumTarihi = DateTime.Today.AddYears(-20);
            if (id != 0)
            {
                musteri = c.Musteris.SingleOrDefault(x => x.Idno == id);
            }
            return View(musteri);
        }
        [HttpPost]
        public IActionResult YeniMusteri(Musteri m)
        {
            if (m.Idno == 0)
            {
                m.Act = 1;
                c.Set<Musteri>().Add(m);
                c.SaveChanges();
                TempData["success"] = "Müşteri eklendi";
            }
            else
            {
                var x = c.Musteris.SingleOrDefault(x => x.Idno == m.Idno);
                x.Adisoyadi = m.Adisoyadi;
                x.DogumTarihi = m.DogumTarihi;
                x.TCNo = m.TCNo;
                x.Telefon = m.Telefon;
                x.Uyruk = m.Uyruk;
                c.Set<Musteri>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Müşteri güncellendi";
            }
            return RedirectToAction("Index", "Musteri");
        }

        public IActionResult AltMusteri(int id)
        {
            var list = c.AltMusteris.Where(x => x.MusteriId == id && x.Act!=0).ToList();
            ViewBag.MusteriId = id;
            return View(list);
        }
        [HttpGet]
        public IActionResult YeniAltMusteri(int id, int ustMusteri)
        {
            AltMusteri musteri = new AltMusteri();
            if (id != 0)
            {
                musteri = c.AltMusteris.SingleOrDefault(x => x.Idno == id && x.MusteriId==ustMusteri && x.Act!=0);
            }
            return View(musteri);
        }
        [HttpPost]
        public IActionResult YeniAltMusteri(AltMusteri m)
        {
            if (m.Idno == 0)
            {
                m.Act = 1;
                c.Set<AltMusteri>().Add(m);
                c.SaveChanges();
                TempData["success"] = "Alt müşteri eklendi";
            }
            else
            {
                var x = c.AltMusteris.SingleOrDefault(x => x.Idno == m.Idno);
                x.AdiSoyadi = m.AdiSoyadi;
                x.DogumTarihi = m.DogumTarihi;
                x.TCNo = m.TCNo;
                x.Uyruk = m.Uyruk;
                c.Set<AltMusteri>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Alt müşteri güncellendi";
            }
            return RedirectToAction("Index", "Musteri");
        }
        public IActionResult MusteriSil(int id)
        {
            if (id != 0)
            {
                var x = c.Musteris.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<Musteri>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Müşteri silindi";
                }
                else
                    TempData["error"] = "Müşteri bulunamadı";
            }
            else
                TempData["error"] = "Müşteri bulunamadı";
            return RedirectToAction("Index", "Musteri");
        }
        public IActionResult AltMusteriSil(int id)
        {
            if (id != 0)
            {
                var x = c.AltMusteris.SingleOrDefault(x => x.Idno == id && x.Act != 0);
                if (x != null)
                {
                    x.Act = 0;
                    c.Set<AltMusteri>().Update(x);
                    c.SaveChanges();
                    TempData["success"] = "Alt Müşteri silindi";
                }
                else
                    TempData["error"] = "Alt Müşteri bulunamadı";
            }
            else
                TempData["error"] = "Alt Müşteri bulunamadı";
            return RedirectToAction("Index", "Musteri");
        }
    }
}
