using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;
            
            kurs kurs1 = new kurs();
            kurs1.kursadi = "c#";
            kurs1.egitmen = "engin";
            kurs1.izlenmeorani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursadi = "java";
            kurs2.egitmen = "pelin";
            kurs2.izlenmeorani = 69;

            kurs kurs3 = new kurs();
            kurs3.kursadi = "python";
            kurs3.egitmen = "muti";
            kurs3.izlenmeorani = 58;

           // Console.WriteLine(kurs1.kursadi + " : " + kurs1.egitmen);
            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi + " : " + kurs.egitmen);

            }


          
        }
    }
    class kurs
    {
        public string kursadi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeorani { get; set; }

    }
    
    
}
