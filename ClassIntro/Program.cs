using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string eadi = "eyyüp";
            int yas = 40;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Eyyüp Sayılır";
            kurs1.IzlenmeOrani = 90;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmeni = "Eyyüp Sayılır";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmeni = "Eyyüp Sayılır";
            kurs3.IzlenmeOrani = 60;

            Console.WriteLine(kurs1.KursAdi +"->" + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "->" + kurs.Egitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
