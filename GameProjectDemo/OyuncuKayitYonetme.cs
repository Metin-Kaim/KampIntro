using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class OyuncuKayitYonetme : IOyuncuKayitServis
    {
        IKisiDogrulamaServis _kisiDogrulamaServis;

        public OyuncuKayitYonetme(IKisiDogrulamaServis kisiDogrulamaServis)
        {
            _kisiDogrulamaServis = kisiDogrulamaServis;
        }

        public void Ekleme(IKullaniciServis kullaniciServis)
        {
            if (_kisiDogrulamaServis.KisiDogrula(kullaniciServis))
                Console.WriteLine(kullaniciServis.Adi + " adlı kişi sisteme EKLENDİ...");
            else
            {
                Console.WriteLine("Girilen bilgiler doğrulanamadı...");
            }
        }

        public void Guncelle(IKullaniciServis kullaniciServis)
        {
            Console.WriteLine(kullaniciServis.Adi + " adlı kişi bilgileri GÜNCELLENDİ...");
        }

        public void Sil(IKullaniciServis kullaniciServis)
        {
            Console.WriteLine(kullaniciServis.Adi + " adlı kişi sistemden SİLİNDİ...");
        }
    }
}
