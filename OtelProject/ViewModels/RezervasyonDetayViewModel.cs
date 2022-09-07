using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.ViewModels
{
    public class RezervasyonDetayViewModel
    {
        public string OdaNo { get; set; }
        public string OdaAdi { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string Pansiyon { get; set; }
        public string OdaTipi { get; set; }
        public string Ucret { get; set; }
        public string EkUcret { get; set; }
        public string Aciklama { get; set; }
        public MusteriViewModel MusteriViewModel{ get; set; }
        public List<AltMusteriViewModel> AltMusteriList{ get; set; }
    }

    public class MusteriViewModel
    {
        public string TCNo { get; set; }
        public string AdiSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Uyruk { get; set; }
        public string Telefon { get; set; }
    }

    public class AltMusteriViewModel
    {
        public string TCNo { get; set; }
        public string AdiSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Uyruk { get; set; }
    }


}
