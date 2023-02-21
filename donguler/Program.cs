using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // butona tıkladıktan sonraki gelen kurs seçenekleri
            string[] kurslar = new string[] {"java","python","c#" };
            
            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i] );
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
