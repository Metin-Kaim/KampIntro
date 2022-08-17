using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IOyuncuKayitServis
    {
        void Ekleme(IKullaniciServis kullaniciServis);

        void Guncelle(IKullaniciServis kullaniciServis);

        void Sil(IKullaniciServis kullaniciServis);
    }
}
