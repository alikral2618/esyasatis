using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace esyasatis.Entities
{
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Email { get; set; }

        public string KullaniciAd { get; set; }

        //[Required(ErrorMessage="Boş Geçilmez")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string sifre { get; set; }

        public string rol { get; set; }
    }
}
