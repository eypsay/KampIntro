using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ////
            //string[] isimler = new string[] {"eyyüp","semra","yunus","zehra" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler =new string[5] dediğimde isimlerin adresini değiştirdiğim için üsteki diziyi kaybederim
            //isimler[3] = "safiye";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);//burası bos gelir cunku atama yapılmadi

            List<string> isimler2 = new List<string> { "eyyüp", "semra", "yunus","zehra" };// List<string> isimler2 = new List<string>();
            Console.WriteLine(isimler2[0]);
            
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("safiye");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
