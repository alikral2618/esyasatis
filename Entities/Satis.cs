using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace esyasatis.Entities
{
    public class Satis
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Ürün")]

        public int UrunID { get; set; }

        [Display(Name = "Adet")]
        public int Urun { get; set; }
        [Display(Name = "Fiyat")]
        public decimal fiyat { get; set; }
        [Display(Name = "Tarih")]

        public DateTime tarih { get; set; }

        //[Required(ErrorMessage="Boş Geçilmez")]
        [Display(Name = "Resim")]

        public string resim { get; set; }
        [Display(Name = "Kullanıcı")]
        public int kullaniciID { get; set; }
    }
}
