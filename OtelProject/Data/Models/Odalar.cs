using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class Odalar
    {
        [Key]
        public int Idno { get; set; }
        public string OdaAdi { get; set; }
        public int OdaNo { get; set; }
        [ForeignKey(nameof(OdaTips))]
        public int OdaTip { get; set; }
        public string Cephe { get; set; }
        public int YatakSayisi { get; set; }
        public string Ozellikler { get; set; }
        public int Act { get; set; }
        public string Aciklama { get; set; }
        public bool Anasayfa { get; set; }
        public virtual OdaTip OdaTips { get; set; }
    }
}
