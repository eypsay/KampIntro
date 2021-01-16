using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product Urun1 = new Product();
            Urun1.urunId = 100;
            Urun1.urunAdi = "Bilgisayar";
            Urun1.urunFiyati = 5000;
            Product Urun2 = new Product();
            Urun2.urunId = 200;
            Urun2.urunAdi = "Telefon";
            Urun2.urunFiyati = 3000;
            Product Urun3 = new Product();
            Urun3.urunId = 300;
            Urun3.urunAdi = "Yazıcı";
            Urun3.urunFiyati = 1000;

            Product[] Urunler = new Product[] { Urun1,Urun2,Urun3 };
            Product eyp = new Product();
            eyp.urunlistele(Urunler);
          
            
        }
    }




        class Product
        {
            public int urunId { get; set; }
            public string urunAdi { get; set; }
            public float urunFiyati { get; set; }

        public void urunlistele(Product[] Urunler)
        {
            foreach (var urun in Urunler)
            {
                Console.WriteLine("Urun Id:" + urunId);
                 Console.WriteLine("Urun Adı:" + urunAdi);
                  Console.WriteLine("Urun Fiyatı:" +urunFiyati);
                  Console.WriteLine("\n");
             }
        }

    }

}
