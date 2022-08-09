﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public int Baslik { get; set; }
        public int Aciklama { get; set; }
        public int AdresAAcik { get; set; }
        public int Mail { get; set; }
        public int Telefon { get; set; }
        public int Konum { get; set; }
    }
}