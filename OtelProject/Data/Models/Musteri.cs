using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class Musteri
    {
        [Key]
        public int Idno { get; set; }
        public string Adisoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TCNo { get; set; }
        public string Uyruk { get; set; }
        public string Telefon { get; set; }
        public int Act { get; set; }
    }
}
