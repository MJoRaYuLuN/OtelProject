using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtelProject.Data.Models;
using OtelProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; 
        private readonly MysqlContext c;
        public HomeController(ILogger<HomeController> logger, MysqlContext c)
        {
            _logger = logger;
            this.c = c;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Rezervasyon(string tarih, string odatip, string pansiyon, string telefon, string yetiskin, string cocuk)
        {
            DateTime suan = DateTime.Now;
            string[] tarihAralik = tarih.Split("-");
            string[] tarih1 = tarihAralik[0].Trim().Split("/");
            string[] tarih2 = tarihAralik[1].Trim().Split("/");

            DateTime baslangic = new DateTime(Convert.ToInt32(tarih1[2]), Convert.ToInt32(tarih1[0]), Convert.ToInt32(tarih1[1]), suan.Hour, suan.Minute, suan.Second);
            DateTime bitis = new DateTime(Convert.ToInt32(tarih2[2]), Convert.ToInt32(tarih2[0]), Convert.ToInt32(tarih2[1]), suan.Hour, suan.Minute, suan.Second);


            Musteri musteri = new Musteri();
            var mus = c.Musteris.FirstOrDefault(x => x.Telefon == telefon);
            if (mus != null)
            {
                musteri.Idno = mus.Idno;
            }
            else
            {
                musteri.Telefon = telefon;
                c.Set<Musteri>().Add(musteri);
                c.SaveChanges();
            }

            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.MusteriId = musteri.Idno;
            rezervasyon.OdaId = 1;
            rezervasyon.GirisTarihi = baslangic;
            rezervasyon.CikisTarihi = bitis;

            rezervasyon.OdaTipId = Convert.ToInt32(odatip);
            rezervasyon.Pansiyon = Convert.ToInt32(pansiyon);
            rezervasyon.Yetiskin = Convert.ToInt32(yetiskin);
            rezervasyon.Cocuk = Convert.ToInt32(cocuk);
            rezervasyon.Act = 1;



            var odaTip = c.OdaTips.FirstOrDefault(x => x.Idno == Convert.ToInt32(odatip));
            var pansiyons = c.Pansiyons.FirstOrDefault(x => x.Idno == Convert.ToInt32(pansiyon));


            TimeSpan gunSayisi = bitis - baslangic;
            double Ucreti = (odaTip.Ucret * gunSayisi.TotalDays) + (pansiyons.Ucret * gunSayisi.TotalDays);
            rezervasyon.Ucret = Ucreti;

            c.Set<Rezervasyon>().Add(rezervasyon);
            c.SaveChanges();

            string json = rezervasyon.Idno.ToString() + "-" + rezervasyon.Ucret.ToString();

            return Json(json);
        }
        public IActionResult RezervasyonIslem(int idno, int durum)
        {
            var rez = c.Rezervasyons.FirstOrDefault(x => x.Idno == idno);
            rez.Act = durum;
            c.Set<Rezervasyon>().Update(rez);
            c.SaveChanges();
            return Json(200);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
