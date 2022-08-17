using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class Calisan : IKullaniciServis
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public long TCNO { get; set; }

        public string Meslek { get; set; }
    }
}
