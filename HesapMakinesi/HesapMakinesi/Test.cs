using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Test
    {
        

        static void Main(string[] args)
        {
            Islemler islem = new Islemler();
            float sonuc = 0;
            Console.WriteLine("*************HESAP MAKİNESİ*************");
            Console.WriteLine("Lütfen işlem yapılacak ilk sayıyı giriniz...");
            float deger1=float.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen işlem yapılacak ikinci sayıyı giriniz...");
            float deger2 = float.Parse(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("***********************İŞLEMLER***********************");
            Console.WriteLine("Toplama işlemi için 1 seçiniz...");
            Console.WriteLine("Çıkarma işlemi için 2 seçiniz...");
            Console.WriteLine("Seçiminizi Giriniz...");
            int secim=int.Parse(Console.ReadLine());
            if (secim==1)
            {
               Console.WriteLine(islem.Toplama(deger1, deger2));

            }
            else if(secim==2)
            {
                Console.WriteLine(islem.Cikarma(deger1, deger2));  
            }

            Console.ReadKey();

        }
    }
}
