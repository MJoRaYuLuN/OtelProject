using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class OdaOzellikSecim
    {
        [Key]
        public int Idno { get; set; }
        [ForeignKey(nameof(Odalar))]
        public int OdaId { get; set; }
        [ForeignKey(nameof(OdaOzellik))]
        public int OzellikId { get; set; }
        public virtual Odalar Odalar { get; set; }
        public virtual OdaOzellik OdaOzellik { get; set; }
    }
}
