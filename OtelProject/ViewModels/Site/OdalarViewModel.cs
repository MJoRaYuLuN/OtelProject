using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.ViewModels.Site
{
    public class OdalarViewModel
    {
        public string OdaAdi { get; set; }
        public string Aciklama { get; set; }
        public int YatakSayisi { get; set; }
        public string Cephe { get; set; }
        public List<OdaOzellikViewModel> OdaOzellikler { get; set; }
        public List<OdaResimViewModel> OdaResimler { get; set; }
        public string Fiyat { get; set; }

    }
    public class OdaOzellikViewModel
    {
        public string Ikon { get; set; }
        public string Baslik { get; set; }
    }
    public class OdaResimViewModel
    {
        public string Resim { get; set; }
    }
}
