using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class Rezervasyon
    {
        [Key]
        public int Idno { get; set; }
        [ForeignKey(nameof(Musteri))]
        public int MusteriId { get; set; }
        [ForeignKey(nameof(Odalar))]
        public int OdaId { get; set; }
        [ForeignKey(nameof(OdaTip))]
        public int OdaTipId { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public double Ucret { get; set; }
        [ForeignKey(nameof(Pansiyons))]
        public int Pansiyon { get; set; }
        public double EkUcret { get; set; }
        public string Aciklama { get; set; }
        public int Yetiskin { get; set; }
        public int Cocuk { get; set; }
        public int Act { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Odalar Odalar { get; set; }
        public virtual OdaTip OdaTip { get; set; }
        public virtual Pansiyon Pansiyons { get; set; }
    }
}
