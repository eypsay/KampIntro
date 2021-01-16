using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //Naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunadi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Urun bilgisi ekle:"+urunadi);
        }
            
    }
}
