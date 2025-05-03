using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace esyasatis.Entities
{
    public class analiz
    {
        [Key]
        public int Yapilacakid { get; set; }

        public string Baslik { get; set; }
    }
}