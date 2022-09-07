using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class AltMusteri
    {
        [Key]
        public int Idno { get; set; }
        [ForeignKey(nameof(Musteri))]
        public int MusteriId { get; set; }
        public string AdiSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TCNo { get; set; }
        public string Uyruk { get; set; }
        public int Act { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
