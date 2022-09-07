using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class Hakkimizda
    {
        [Key]
        public int Idno { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik { get; set; }
        public string Icerik { get; set; }
    }
}
