using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            //Dinamik olarak listelene için array
            string[] kurslar = new string[] { "Yazılım Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java" ,"Python","C#"};


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\nFor bitti!!!\n");
            foreach (string kurs in kurslar)   
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\nSayfa Sonu!!!");
        }
    }
}
