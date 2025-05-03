using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;


namespace esyasatis.Entities
{
    public class kategori
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "max 50 karakter")]

        public string ad { get; set; }

        public string kategori_isim { get; set; }


        public virtual List<Urun> Urun { get; set; }
    }
}