using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Değer tutucu , alias
            string kategoriEtiketi = "Kategoriler";
            bool sistemeGirisyapilmismi = true;
            double dolardun = 7.45;
            //sitedeki giriş yaptığımız butonlar
            
            if (sistemeGirisyapilmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
             

        }
    }
}
