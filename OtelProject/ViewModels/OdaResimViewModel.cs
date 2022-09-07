using Microsoft.AspNetCore.Http;
using OtelProject.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.ViewModels
{
    public class OdaResimViewModel
    {
        public int Idno { get; set; }
        public int OdaId { get; set; }
        public IFormFile Resim { get; set; }
        public int Act { get; set; }
    }
}
