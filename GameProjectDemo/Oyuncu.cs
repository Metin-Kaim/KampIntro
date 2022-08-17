using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class Oyuncu : IKullaniciServis
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public long TCNO { get; set; }
    }
}
