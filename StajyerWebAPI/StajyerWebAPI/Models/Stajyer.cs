
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StajyerWebAPI.Models
{
    public class Stajyer
    {
        public int StajyerID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCNo { get; set; }
        public string Okul { get; set; }
        public string Bolum { get; set; }
        public DateTime KayitTar { get; set; }
        public DateTime CikisTar { get; set; }

    }
}
