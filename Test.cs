using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HesapMakinesi
{
    class Program
    {
       
        static void Main(string[] args)
        {
            float sonuc=0,deger1,deger2;
            Islemler obj = new Islemler();
            Console.WriteLine("Çarpma işlemini yapacağınız sayıları giriniz:...");
            deger1 = Convert.ToInt16(Console.ReadLine());
            deger2 = Convert.ToInt16(Console.ReadLine());
            sonuc = obj.Carpma(deger1,deger2);

            Console.WriteLine(sonuc);
            Console.Read();
        }
    }
}
