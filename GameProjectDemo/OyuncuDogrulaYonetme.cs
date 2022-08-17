using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class OyuncuDogrulaYonetme : IKisiDogrulamaServis
    {//mernis doğrulaması
        public bool KisiDogrula(IKullaniciServis kullaniciServis)
        {
            if (kullaniciServis.Id < 10)
                return true;
            else
                return false;
        }
    }
}
