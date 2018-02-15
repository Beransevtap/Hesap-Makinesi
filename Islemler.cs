using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HesapMakinesi
{
    class Islemler
    {
        float deger1;
        float deger2;
        float sonuc = 0;

        public float Carpma(float deger1, float deger2)
        {
            sonuc = deger1 * deger2;
            return sonuc;
        }
    }
}
