using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IKullaniciServis oyuncu1 = new Oyuncu { Id = 12, Adi = "Caesar", Soyadi = "Ape", TCNO = 12345678910 };
            IKullaniciServis oyuncu2 = new Oyuncu { Id = 3, Adi = "Alpha", Soyadi = "Ape", TCNO = 12345678910 };
            IKullaniciServis calisan1 = new Calisan { Id = 1, Adi = "Mehmet", Soyadi = "Ape", TCNO = 12345678910, Meslek="Bakım Ve Onarım"};

            OyuncuKayitYonetme oyuncuKayitYonetme = new OyuncuKayitYonetme(new OyuncuDogrulaYonetme());

            oyuncuKayitYonetme.Ekleme(oyuncu1);
            oyuncuKayitYonetme.Ekleme(oyuncu2);
            oyuncuKayitYonetme.Ekleme(calisan1);
            oyuncuKayitYonetme.Sil(oyuncu1);
            oyuncuKayitYonetme.Guncelle(oyuncu2);
        }
    }
}
