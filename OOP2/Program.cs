using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "112233";
            musteri1.Adi = "eyyüp";            
            musteri1.Soyadi = "sayilir";
            musteri1.TcNo = "123123456";
            

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "998877";
            musteri2.SirketAdi = "Sayilir Corp";
            musteri2.VergiNo = "123456";


            //Gercek--Tuzel


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.add(musteri1);
            customerManager.add(musteri2);



        }
    }
}
