using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class OdaOzellik
    {
        [Key]
        public int Idno { get; set; }
        public string Ikon { get; set; }
        public string Baslik { get; set; }
        public int Act { get; set; }
    }
}
