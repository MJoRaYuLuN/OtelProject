using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class OdaResim
    {
        [Key]
        public int Idno { get; set; }
        [ForeignKey(nameof(Odalar))]
        public int OdaId { get; set; }
        public string Resim { get; set; }
        public int Act { get; set; }
        public virtual Odalar Odalar { get; set; }
    }
}
