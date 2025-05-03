using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esyasatis.Entities
{
    public class Urun
    {
        [Key]
        public int ID { get; set; }

        public string UrunAd { get; set; }

        public string Aciklama { get; set; }

        public decimal Fiyat { get; set; }

        public int Stok { get; set; }

        public bool yeniurun { get; set; }

        public bool Onay { get; set; }

        public string resim { get; set; }

        public int adet { get; set; }

        public int kategoriID { get; set; }
        public virtual kategori kategori { get; set; }


    }
}