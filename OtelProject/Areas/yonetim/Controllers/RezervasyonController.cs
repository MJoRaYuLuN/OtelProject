using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OtelProject.Data.Models;
using OtelProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Areas.yonetim.Controllers
{
    [Area("Yonetim")]
    public class RezervasyonController : Controller
    {
        private readonly MysqlContext c;
        public RezervasyonController(MysqlContext c)
        {
            this.c = c;
        }
        public IActionResult Index()
        {
            var list = c.Rezervasyons.Include(x => x.Musteri).Include(x => x.OdaTip).Include(x => x.Pansiyons).Where(x => x.Act != 0 && x.Act != 3).ToList();
            List<SelectListItem> odalist = (from p in c.Odalars.ToList().Where(p => p.Act == 1).OrderBy(p => p.OdaNo)
                                            select new SelectListItem
                                            {
                                                Text = p.OdaNo + " - " + p.OdaAdi,
                                                Value = p.Idno.ToString()
                                            }).ToList();
            ViewBag.odaListe = odalist;
            return View(list);
        }
        public IActionResult EskiRezervasyon()
        {
            var list = c.Rezervasyons.Include(x => x.Musteri).Include(x => x.OdaTip).Include(x => x.Pansiyons).Where(x => x.Act == 3).ToList();
            return View(list);
        }


        public IActionResult RezervasyonGetir(int id)
        {
            RezervasyonDetayViewModel detay = new RezervasyonDetayViewModel();
            var rez = c.Rezervasyons.Include(x => x.Musteri).Include(x => x.Pansiyons).Include(x => x.OdaTip).SingleOrDefault(x => x.Idno == id);
            detay.OdaAdi = "";
            detay.OdaNo = "";
            if (rez.OdaId != 0)
            {
                var oda = c.Odalars.FirstOrDefault(x => x.Idno == rez.OdaId);
                detay.OdaAdi = oda.OdaAdi;
                detay.OdaNo = oda.OdaNo.ToString();

            }
            detay.GirisTarihi = rez.GirisTarihi;
            detay.CikisTarihi = rez.CikisTarihi;
            detay.Pansiyon = rez.Pansiyons.Baslik;
            detay.OdaTipi = rez.OdaTip.Baslik;
            detay.Ucret = rez.Ucret.ToString("N2");
            detay.EkUcret = rez.EkUcret.ToString("N2");
            detay.Aciklama = rez.Aciklama;

            detay.MusteriViewModel = new MusteriViewModel();
            detay.MusteriViewModel.AdiSoyadi = rez.Musteri.Adisoyadi;
            detay.MusteriViewModel.TCNo = rez.Musteri.TCNo;
            detay.MusteriViewModel.DogumTarihi = rez.Musteri.DogumTarihi;
            detay.MusteriViewModel.Telefon = rez.Musteri.Telefon;
            detay.MusteriViewModel.Uyruk = rez.Musteri.Uyruk;

            detay.AltMusteriList = new List<AltMusteriViewModel>();
            var altMusteriList = c.AltMusteris.Where(x => x.Act == 1 && x.MusteriId == rez.MusteriId).ToList();
            if (altMusteriList != null)
            {
                foreach (var item in altMusteriList)
                {
                    AltMusteriViewModel altMus = new AltMusteriViewModel();
                    altMus.AdiSoyadi = item.AdiSoyadi;
                    altMus.TCNo = item.TCNo;
                    altMus.DogumTarihi = item.DogumTarihi;
                    altMus.Uyruk = item.Uyruk;
                    detay.AltMusteriList.Add(altMus);
                }
            }
            return View(detay);
        }


        public IActionResult RezervasyonOnay(int id, int OdaId)
        {
            var dolumu = c.Rezervasyons.FirstOrDefault(x => x.Act == 2 && x.OdaId == OdaId);
            if (dolumu == null)
            {
                var x = c.Rezervasyons.SingleOrDefault(x => x.Idno == id);
                x.OdaId = OdaId;
                x.Act = 2;
                c.Set<Rezervasyon>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Rezervasyon işlemi tamamlandı";
            }
            else
            {
                TempData["error"] = "Oda dolu! Lütfen başka bir oda seçiniz.";
            }


            return RedirectToAction("Index", "Rezervasyon");
        }
        public IActionResult RezervasyonCikis(int id, DateTime cikistarih, double ekucret, string aciklama)
        {
            var x = c.Rezervasyons.SingleOrDefault(x => x.Idno == id);
            x.Act = 3;
            x.CikisTarihi = cikistarih;
            x.EkUcret = ekucret;
            x.Aciklama = aciklama;
            c.Set<Rezervasyon>().Update(x);
            c.SaveChanges();
            TempData["success"] = "Odadan başarıyla çıkış yapıldı.";
            return RedirectToAction("Index", "Rezervasyon");
        }
        public IActionResult RezervasyonSil(int id)
        {
            var x = c.Rezervasyons.SingleOrDefault(x => x.Idno == id);
            if (x != null)
            {
                x.Act = 0;
                c.Set<Rezervasyon>().Update(x);
                c.SaveChanges();
                TempData["success"] = "Rezervasyon başarıyla silindi.";
            }
            else
                TempData["error"] = "Rezervasyon Bulunamadı!";

            return RedirectToAction("Index", "Rezervasyon");
        }


        public IActionResult OdaDurum(int id)
        {
            string json = "";
            List<OdaDurumViewModel> odaList = new List<OdaDurumViewModel>();
            var odalar = c.Odalars.Where(x => x.Act != 0).ToList();
            var rezervasyonlar = c.Rezervasyons.Where(x => x.Act == 2).ToList();
            foreach (var item in odalar)
            {
                OdaDurumViewModel oda = new OdaDurumViewModel();
                oda.OdaAdi = item.OdaAdi;
                oda.OdaNo = item.OdaNo.ToString();
                oda.Durum = "Boş";
                var durum = rezervasyonlar.SingleOrDefault(x => x.OdaId == item.Idno);
                if (durum != null)
                    oda.Durum = "Dolu";
                odaList.Add(oda);
            }
            json = JsonConvert.SerializeObject(odaList);
            return Json(json);

        }
    }
}
