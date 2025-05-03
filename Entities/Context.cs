using esyasatis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esyasatis.Entities
{
    public class Context : DbContext
    {
        public DbSet<sepet> sepets { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<kategori> kategoris { get; set; }
        public DbSet<Kullanici> kullanicis { get; set; }
        public DbSet<Satis> satis { get; set; }

      
        public DbSet<analiz> analizs { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
