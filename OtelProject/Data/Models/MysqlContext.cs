using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProject.Data.Models
{
    public class MysqlContext:DbContext
    {
        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options)
        {
        }
        public DbSet<AltMusteri> AltMusteris { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Odalar> Odalars { get; set; }
        public DbSet<OdaOzellik> OdaOzelliks { get; set; }
        public DbSet<OdaOzellikSecim> OdaOzellikSecims { get; set; }
        public DbSet<OdaResim> OdaResims { get; set; }
        public DbSet<OdaTip> OdaTips { get; set; }
        public DbSet<Pansiyon> Pansiyons { get; set; }
        public DbSet<Rezervasyon> Rezervasyons { get; set; }
        public DbSet<Yonetici> Yoneticis { get; set; }
    }
}
