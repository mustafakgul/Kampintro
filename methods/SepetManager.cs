using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class SepetManager
    {
        public void Ekle (Urun urun)
        {
            Console.WriteLine("tebrikler.sepete eklendi:"+ urun.Adi);
        }
         public void Ekle2(string urunAdi,string Aciklamasi,double Fiyat,int StokAdedi)
        {
            Console.WriteLine("tebrikler.sepete eklendi:" + urunAdi);



        }



    }
}
